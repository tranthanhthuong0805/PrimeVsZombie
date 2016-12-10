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
    
    
    public class TargetView : TargetViewBase {
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as TargetViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Target to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }

        void Update()
        {
            Vector3 temp1 = transform.position;
            temp1.x = Input.mousePosition.x - 427;
            temp1.y = Input.mousePosition.y - 240;
            transform.position = temp1;
        }
    }
}
