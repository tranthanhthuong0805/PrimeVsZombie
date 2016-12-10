// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PrimeVsZombieDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class PrimeControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.ViewModels.IViewModelManager _PrimeViewModelManager;
        
        private PrimeViewModel _Prime;
        
        private GamePlayViewModel _GamePlay;
        
        [uFrame.IOC.InjectAttribute("Prime")]
        public uFrame.MVVM.ViewModels.IViewModelManager PrimeViewModelManager {
            get {
                return _PrimeViewModelManager;
            }
            set {
                _PrimeViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("Prime")]
        public PrimeViewModel Prime {
            get {
                return _Prime;
            }
            set {
                _Prime = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("GamePlay")]
        public GamePlayViewModel GamePlay {
            get {
                return _GamePlay;
            }
            set {
                _GamePlay = value;
            }
        }
        
        public IEnumerable<PrimeViewModel> PrimeViewModels {
            get {
                return PrimeViewModelManager.OfType<PrimeViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializePrime(((PrimeViewModel)(viewModel)));
        }
        
        public virtual PrimeViewModel CreatePrime() {
            return ((PrimeViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new PrimeViewModel(this.EventAggregator);
        }
        
        public virtual void InitializePrime(PrimeViewModel viewModel) {
            // This is called when a PrimeViewModel is created
            viewModel.MoveDown.Action = this.MoveDownHandler;
            viewModel.MoveRight.Action = this.MoveRightHandler;
            viewModel.MoveUp.Action = this.MoveUpHandler;
            viewModel.MoveStop.Action = this.MoveStopHandler;
            viewModel.MoveLeft.Action = this.MoveLeftHandler;
            PrimeViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            PrimeViewModelManager.Remove(viewModel);
        }
        
        public virtual void MoveDown(PrimeViewModel viewModel) {
        }
        
        public virtual void MoveRight(PrimeViewModel viewModel) {
        }
        
        public virtual void MoveUp(PrimeViewModel viewModel) {
        }
        
        public virtual void MoveStop(PrimeViewModel viewModel) {
        }
        
        public virtual void MoveLeft(PrimeViewModel viewModel) {
        }
        
        public virtual void MoveDownHandler(MoveDownCommand command) {
            this.MoveDown(command.Sender as PrimeViewModel);
        }
        
        public virtual void MoveRightHandler(MoveRightCommand command) {
            this.MoveRight(command.Sender as PrimeViewModel);
        }
        
        public virtual void MoveUpHandler(MoveUpCommand command) {
            this.MoveUp(command.Sender as PrimeViewModel);
        }
        
        public virtual void MoveStopHandler(MoveStopCommand command) {
            this.MoveStop(command.Sender as PrimeViewModel);
        }
        
        public virtual void MoveLeftHandler(MoveLeftCommand command) {
            this.MoveLeft(command.Sender as PrimeViewModel);
        }
    }
}
