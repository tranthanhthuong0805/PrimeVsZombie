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
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public partial class GamePlayViewModelBase : uFrame.MVVM.ViewModels.ViewModel {
        
        private P<PrimeViewModel> _PrimeProperty;
        
        private P<ZombieViewModel> _ZombiesProperty;
        
        public GamePlayViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<PrimeViewModel> PrimeProperty {
            get {
                return _PrimeProperty;
            }
            set {
                _PrimeProperty = value;
            }
        }
        
        public virtual P<ZombieViewModel> ZombiesProperty {
            get {
                return _ZombiesProperty;
            }
            set {
                _ZombiesProperty = value;
            }
        }
        
        public virtual PrimeViewModel Prime {
            get {
                return PrimeProperty.Value;
            }
            set {
                PrimeProperty.Value = value;
            }
        }
        
        public virtual ZombieViewModel Zombies {
            get {
                return ZombiesProperty.Value;
            }
            set {
                ZombiesProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _PrimeProperty = new P<PrimeViewModel>(this, "Prime");
            _ZombiesProperty = new P<ZombieViewModel>(this, "Zombies");
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            		if (stream.DeepSerialize) this.Prime = stream.DeserializeObject<PrimeViewModel>("Prime");;
            		if (stream.DeepSerialize) this.Zombies = stream.DeserializeObject<ZombieViewModel>("Zombies");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            if (stream.DeepSerialize) stream.SerializeObject("Prime", this.Prime);;
            if (stream.DeepSerialize) stream.SerializeObject("Zombies", this.Zombies);;
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_PrimeProperty, true, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_ZombiesProperty, true, false, false, false));
        }
    }
    
    public partial class GamePlayViewModel {
        
        public GamePlayViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
