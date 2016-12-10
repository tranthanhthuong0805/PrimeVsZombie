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
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public class GamePlayViewBase : uFrame.MVVM.Views.ViewBase {
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _Prime;
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public uFrame.MVVM.Views.ViewBase _Zombies;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("Prime")]
        [UnityEngine.HideInInspector()]
        public bool _BindPrime = true;
        
        [uFrame.MVVM.Attributes.UFGroup("Prime")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_PrimeonlyWhenChanged")]
        protected bool _PrimeOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("Zombies")]
        [UnityEngine.HideInInspector()]
        public bool _BindZombies = true;
        
        [uFrame.MVVM.Attributes.UFGroup("Zombies")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_ZombiesonlyWhenChanged")]
        protected bool _ZombiesOnlyWhenChanged;
        
        public override string DefaultIdentifier {
            get {
                return "GamePlay";
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(GamePlayViewModel);
            }
        }
        
        public GamePlayViewModel GamePlay {
            get {
                return (GamePlayViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as GamePlayViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
            var gameplayview = ((GamePlayViewModel)model);
            gameplayview.Prime = this._Prime == null ? null :  ViewService.FetchViewModel(this._Prime) as PrimeViewModel;
            gameplayview.Zombies = this._Zombies == null ? null :  ViewService.FetchViewModel(this._Zombies) as ZombieViewModel;
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.GamePlay to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindPrime) {
                this.BindProperty(this.GamePlay.PrimeProperty, this.PrimeChanged, _PrimeOnlyWhenChanged);
            }
            if (_BindZombies) {
                this.BindProperty(this.GamePlay.ZombiesProperty, this.ZombiesChanged, _ZombiesOnlyWhenChanged);
            }
        }
        
        public virtual void PrimeChanged(PrimeViewModel arg1) {
        }
        
        public virtual void ZombiesChanged(ZombieViewModel arg1) {
        }
    }
}