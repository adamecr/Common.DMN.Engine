using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.results;

namespace net.adamec.lib.common.dmn.engine.simulator.controls.common
{
    public class TreeViewEx : TreeView
    {
        /// <summary>
        /// Dependency property for Command to be executed when an selectable DMN element (Decision or Input) is selected within the tree
        /// </summary>
        public static DependencyProperty SelectDmnElementCommandProperty = DependencyProperty.Register(
            "SelectDmnElementCommand",
            typeof(ICommand),
            typeof(TreeViewEx));

        /// <summary>
        /// Command to be executed when an selectable DMN element (Decision or Input) is selected within the tree
        /// </summary>
        public ICommand? SelectDmnElementCommand
        {
            get => (ICommand)GetValue(SelectDmnElementCommandProperty);
            set => SetValue(SelectDmnElementCommandProperty, value);
        }

        /// <summary>
        /// Handles the selected item changes.
        /// When the newly selected item is <see cref="IItemWithSelectableDmnElement"/> and it also executes the <see cref="SelectDmnElementCommand"/>
        /// to propagate the selection change
        /// </summary>
        /// <param name="e">Event arguments</param>
        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
        {
            base.OnSelectedItemChanged(e);
            if (SelectedItem is not IItemWithSelectableDmnElement { SelectableDmnElement: { } } item || SelectDmnElementCommand is null) return;

            var element = item.SelectableDmnElement;
            if (SelectDmnElementCommand.CanExecute(element))
            {
                SelectDmnElementCommand.Execute(element);
            }
        }
    }
}
