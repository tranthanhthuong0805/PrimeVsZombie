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
    
    
    public class GamePlayControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.ViewModels.IViewModelManager _GamePlayViewModelManager;
        
        private PrimeViewModel _Prime;
        
        private GamePlayViewModel _GamePlay;
        
        [uFrame.IOC.InjectAttribute("GamePlay")]
        public uFrame.MVVM.ViewModels.IViewModelManager GamePlayViewModelManager {
            get {
                return _GamePlayViewModelManager;
            }
            set {
                _GamePlayViewModelManager = value;
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
        
        public IEnumerable<GamePlayViewModel> GamePlayViewModels {
            get {
                return GamePlayViewModelManager.OfType<GamePlayViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeGamePlay(((GamePlayViewModel)(viewModel)));
        }
        
        public virtual GamePlayViewModel CreateGamePlay() {
            return ((GamePlayViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new GamePlayViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeGamePlay(GamePlayViewModel viewModel) {
            // This is called when a GamePlayViewModel is created
            GamePlayViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            GamePlayViewModelManager.Remove(viewModel);
        }
    }
}
