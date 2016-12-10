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
    
    
    public class ZombieView : ZombieViewBase {
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as ZombieViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Zombie to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }

        public float speed = 100;

        public override void Update()
        {
            base.Update();
            Vector3 temp = transform.position;
            temp.x = temp.x - (100 * Time.deltaTime);
            transform.position = temp;
        }

        //public void Start()
        //{
        //    transform.position = new Vector3(3200, UnityEngine.Random.Range(-224, -90));

        //    Observable.EveryUpdate().Subscribe(_ =>
        //    {
        //        transform.Translate(-speed, 0, 0);
        //    });
        //}
    }
}
