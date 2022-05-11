using System;
using System.Diagnostics;
using System.Windows.Input;

namespace net.adamec.lib.common.dmn.engine.simulator.mvvm
{
    /// <summary>
    /// Defines the command that can be used in view models
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Empty command (just does nothing when executed)
        /// </summary>
        public static RelayCommand Empty = new(_ => { });

        /// <summary>
        /// Command action to be executed (with optional parameter)
        /// </summary>
        readonly Action<object?> actionToExecute;
        /// <summary>

        /// Optional predicate (condition) whether the command can execute (with optional command parameter)
        /// </summary>
        readonly Predicate<object?>? canExecuteCondition;

        /// <summary>
        /// Event used when the command ability (condition) to execute changed
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="action">Command action to be executed (with optional parameter)</param>
        public RelayCommand(Action<object?> action) : this(action, null) { }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="action">Command action to be executed (with optional parameter)</param>
        /// <param name="canExecute">Optional predicate (condition) whether the command can execute (with optional command parameter)</param>
        /// <exception cref="ArgumentNullException">Exception thrown when <paramref name="action"/> is null</exception>
        public RelayCommand(Action<object?> action, Predicate<object?>? canExecute)
        {
            actionToExecute = action ?? throw new ArgumentNullException(nameof(action));
            canExecuteCondition = canExecute;
        }

        /// <summary>
        /// Returns the information whether the command can execute
        /// </summary>
        /// <param name="parameter">Optional command parameter</param>
        /// <returns>True when the command can execute</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object? parameter)
        {
            return canExecuteCondition == null || canExecuteCondition(parameter);
        }

        /// <summary>
        /// Execute the command action with optional parameter 
        /// </summary>
        /// <param name="parameter">Optional command parameter</param>
        public void Execute(object? parameter)
        {
            if (CanExecute(parameter))
                actionToExecute(parameter);
        }

    }
}
