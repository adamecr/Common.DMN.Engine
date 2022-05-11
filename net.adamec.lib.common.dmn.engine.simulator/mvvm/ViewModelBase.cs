using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace net.adamec.lib.common.dmn.engine.simulator.mvvm
{
    /// <summary>
    /// Base class for view model
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raise <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propertyName">Name of the property </param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            VerifyPropertyName(propertyName);
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Sets the property <paramref name="backingField"/> with the <paramref name="newValue"/> if the new value is different than the current one
        /// and raise <see cref="PropertyChanged"/> event for the <paramref name="propertyName"/> (auto-set by <see cref="CallerMemberNameAttribute"/>)
        /// </summary>
        /// <typeparam name="TValue">Type of the property</typeparam>
        /// <param name="backingField">Property backing field reference</param>
        /// <param name="newValue">New property value</param>
        /// <param name="propertyName">Property value</param>
        /// <param name="beforeUpdateAction">Optional action to be called before the property backing field is updated</param>
        /// <param name="afterUpdateAction">Optional action to be called  after the property backing field is updated</param>
        /// <returns>New value of the property</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="propertyName"/> is null</exception>
        public TValue Change<TValue>(ref TValue? backingField, TValue newValue,
           [CallerMemberName] string? propertyName = null,
           Action<TValue?>? beforeUpdateAction = null, Action<TValue?>? afterUpdateAction = null)
        {
            if (propertyName is null) throw new ArgumentNullException(nameof(propertyName));

            if (EqualityComparer<TValue>.Default.Equals(backingField, newValue))
            {
                return newValue;
            }

            beforeUpdateAction?.Invoke(newValue);
            backingField = newValue;
            OnPropertyChanged(propertyName);
            afterUpdateAction?.Invoke(newValue);
            return newValue;
        }

        /// <summary>
        /// Sets the property <paramref name="backingField"/> with the <paramref name="newValue"/> if the new value is different than the current one
        /// and raise <see cref="PropertyChanged"/> event for the <paramref name="propertyName"/> (auto-set by <see cref="CallerMemberNameAttribute"/>)
        /// </summary>
        /// <param name="backingField">Property backing field reference</param>
        /// <param name="newValue">New property value</param>
        /// <param name="nullToEmpty">Flag whether to set the new value as <see cref="string.Empty"/> when a <paramref name="newValue"/> is null</param>
        /// <param name="invariantAndIgnoreCase">Flag whether to use the invariant culture and ignore case when checking whether the value changed</param>
        /// <param name="propertyName">Property value</param>
        /// <param name="beforeUpdateAction">Optional action to be called before the property backing field is updated</param>
        /// <param name="afterUpdateAction">Optional action to be called  after the property backing field is updated</param>
        /// <returns>New value of the property</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="propertyName"/> is null</exception>
        public string? Change(ref string? backingField, string? newValue, bool nullToEmpty = false,
             bool invariantAndIgnoreCase = false, [CallerMemberName] string? propertyName = null,
             Action<string?>? beforeUpdateAction = null, Action<string?>? afterUpdateAction = null)
        {
            if (propertyName is null) throw new ArgumentNullException(nameof(propertyName));

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (newValue == null && nullToEmpty) newValue = string.Empty;

            if (string.Equals(backingField, newValue, invariantAndIgnoreCase ? StringComparison.InvariantCultureIgnoreCase : StringComparison.CurrentCulture))
            {
                return newValue;
            }

            beforeUpdateAction?.Invoke(newValue);
            backingField = newValue;
            OnPropertyChanged(propertyName);
            afterUpdateAction?.Invoke(newValue);
            return newValue;
        }

        /// <summary>
        /// Verify that the <paramref name="propertyName"/> matches the existing property - used in debug build only.
        /// Throws an exception when the property doesn't exist
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(string propertyName)
        {
            if (TypeDescriptor.GetProperties(this)[propertyName] != null) return;

            var msg = $"Property {propertyName} does not exist";
            Debug.Fail(msg);
            throw new Exception(msg);
        }
    }
}
