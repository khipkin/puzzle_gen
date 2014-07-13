using PuzzleGenerator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PuzzleGenerator.Commands
{
    class NewPuzzleCommand : ICommand
    {
        /// <summary>
        /// The MainWindowVM.
        /// </summary>
        private MainWindowVM _theVM;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="theVM">The MainWindowVM.</param>
        public NewPuzzleCommand(MainWindowVM theVM)
        {
            this._theVM = theVM;
        }

        /// <summary>
        /// Determines if "New" button is enabled or disabled.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Creates a new puzzle.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
