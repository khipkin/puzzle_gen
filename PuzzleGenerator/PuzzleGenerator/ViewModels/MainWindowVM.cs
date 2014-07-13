using PuzzleGenerator.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PuzzleGenerator.ViewModels
{
    class MainWindowVM
    {
        /// <summary>
        /// 
        /// </summary>
        public ICommand NewPuzzleCommand { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindowVM()
        {
            this.NewPuzzleCommand = new NewPuzzleCommand(this);
        }
    }
}
