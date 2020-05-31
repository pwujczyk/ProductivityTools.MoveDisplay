using ProductivityTools.MoveDisplay.UI.Dialog;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Input;

namespace ProductivityTools.MoveDisplay.UI
{
    public class MainWindowVM
    {
        public ICommand MoveToLeftCommand { get; }
        public ICommand MoveToRightCommand { get; }
        private readonly IDialogService DialogService;

        public MainWindowVM(IDialogService dialogService)
        {
            MoveToLeftCommand = new CommandHandler(MoveToLeft, () => true);
            MoveToRightCommand = new CommandHandler(MoveToRight, () => true);
            this.DialogService = dialogService;
        }

        private void MoveDisplay(Direction direction)
        {
            ProductivityTools.UnmanagedDisplayWrapper.Displays displays = new UnmanagedDisplayWrapper.Displays();
            displays.LoadData();

            Action move = () =>
              {
                  switch (direction)
                  {
                      case Direction.Left:
                          displays.MoveExternalDisplayToLeft();
                          break;
                      case Direction.Right:
                          displays.MoveExternalDisplayToRight();
                          break;
                      default:
                          throw new Exception("Direction is wrong");
                  }
              };


            int displayAmount = displays.Count;
            switch (displayAmount)
            {
                case 0: this.DialogService.NoDisplayDetected(); return;
                case 1: this.DialogService.OneDisplayMessage(); return;
                case 2: move(); return;
                default:
                    this.DialogService.MoreThanTwoDisplaysMessage(); return;
            }
        }

        private void MoveToLeft()
        {
            MoveDisplay(Direction.Left);
        }

        private void MoveToRight()
        {
            MoveDisplay(Direction.Right);
        }
    }
}
