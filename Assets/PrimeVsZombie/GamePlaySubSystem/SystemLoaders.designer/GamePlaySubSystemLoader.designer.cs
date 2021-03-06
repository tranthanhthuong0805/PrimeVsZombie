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
    using PrimeVsZombieDB;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class GamePlaySubSystemLoaderBase : uFrame.Kernel.SystemLoader {
        
        private PrimeViewModel _Prime;
        
        private GamePlayViewModel _GamePlay;
        
        private ZombieController _ZombieController;
        
        private PrimeController _PrimeController;
        
        private GamePlayController _GamePlayController;
        
        private TargetController _TargetController;
        
        [uFrame.IOC.InjectAttribute("Prime")]
        public virtual PrimeViewModel Prime {
            get {
                if (this._Prime == null) {
                    this._Prime = this.CreateViewModel<PrimeViewModel>( "Prime");
                }
                return _Prime;
            }
        }
        
        [uFrame.IOC.InjectAttribute("GamePlay")]
        public virtual GamePlayViewModel GamePlay {
            get {
                if (this._GamePlay == null) {
                    this._GamePlay = this.CreateViewModel<GamePlayViewModel>( "GamePlay");
                }
                return _GamePlay;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual ZombieController ZombieController {
            get {
                if (_ZombieController==null) {
                    _ZombieController = Container.CreateInstance(typeof(ZombieController)) as ZombieController;;
                }
                return _ZombieController;
            }
            set {
                _ZombieController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual PrimeController PrimeController {
            get {
                if (_PrimeController==null) {
                    _PrimeController = Container.CreateInstance(typeof(PrimeController)) as PrimeController;;
                }
                return _PrimeController;
            }
            set {
                _PrimeController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual GamePlayController GamePlayController {
            get {
                if (_GamePlayController==null) {
                    _GamePlayController = Container.CreateInstance(typeof(GamePlayController)) as GamePlayController;;
                }
                return _GamePlayController;
            }
            set {
                _GamePlayController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual TargetController TargetController {
            get {
                if (_TargetController==null) {
                    _TargetController = Container.CreateInstance(typeof(TargetController)) as TargetController;;
                }
                return _TargetController;
            }
            set {
                _TargetController = value;
            }
        }
        
        public override void Load() {
            Container.RegisterViewModelManager<ZombieViewModel>(new ViewModelManager<ZombieViewModel>());
            Container.RegisterController<ZombieController>(ZombieController);
            Container.RegisterViewModelManager<PrimeViewModel>(new ViewModelManager<PrimeViewModel>());
            Container.RegisterController<PrimeController>(PrimeController);
            Container.RegisterViewModelManager<GamePlayViewModel>(new ViewModelManager<GamePlayViewModel>());
            Container.RegisterController<GamePlayController>(GamePlayController);
            Container.RegisterViewModelManager<TargetViewModel>(new ViewModelManager<TargetViewModel>());
            Container.RegisterController<TargetController>(TargetController);
            Container.RegisterViewModel<PrimeViewModel>(Prime, "Prime");
            Container.RegisterViewModel<GamePlayViewModel>(GamePlay, "GamePlay");
        }
    }
}
