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
    using uFrame.MVVM.Views;
    using UniRx;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public class GamePlayView : GamePlayViewBase {
        
        // ReSharper disable once RedundantOverridenMember
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as GamePlayViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        // ReSharper disable once RedundantOverridenMember
        public override void Bind() {
            base.Bind();
            // Use this.GamePlay to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }

        public override void PrimeChanged(PrimeViewModel arg1)
        {
            base.PrimeChanged(arg1);
            if (arg1 == null) return;
            Observable.FromCoroutine(() =>
                    InitPrimeView(arg1))
                    .Subscribe(i => { }, InitPrimeViewDone);
        }

        private ViewBase viewBasePrime;


        private IEnumerator InitPrimeView(ViewModel viewModel, bool active = true)
        {
            viewBasePrime = InstantiateView(viewModel);
            InitTransPrime(viewBasePrime, active);

            return null;
        }

        private void InitTransPrime(Component viewBase, bool active)
        {
            var trans = viewBase.transform;
            trans.localScale = Vector3.one;
            trans.localPosition = new Vector3(0, -140, 0);
            trans.gameObject.SetActive(active);
        }

        private void InitPrimeViewDone()
        {
            
        }

        public override void ZombiesChanged(ZombieViewModel arg1)
        {
            base.ZombiesChanged(arg1);
            if (arg1 == null) return;
            Observable.FromCoroutine(() =>
                    InitZombieView(arg1))
                    .Subscribe(i => { }, InitZombieViewDone);
        }

        private ViewBase viewBaseZombie;


        private IEnumerator InitZombieView(ViewModel viewModel, bool active = true)
        {
            viewBaseZombie = InstantiateView(viewModel);
            InitTransZombie(viewBaseZombie, active);

            return null;
        }

        private void InitTransZombie(Component viewBase, bool active)
        {
            var trans = viewBase.transform;
            trans.localScale = Vector3.one;
            trans.localPosition = new Vector3(3200, UnityEngine.Random.Range(-224, -90));
            trans.gameObject.SetActive(active);
        }

        private void InitZombieViewDone()
        {

        }

        void Update()
        {
            Vector3 temp1 = Camera.main.transform.position;
            temp1.x = transform.GetChild(3).position.x;
            Camera.main.transform.position = temp1;
            transform.GetChild(1).position = new Vector3(1315.5f ,0 , 0);
        }
    }
}
