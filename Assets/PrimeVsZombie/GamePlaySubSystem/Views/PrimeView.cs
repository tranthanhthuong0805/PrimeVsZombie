using DG.Tweening;

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
    
    
    public class PrimeView : PrimeViewBase {
        
        public override void MoveLeftExecuted(MoveLeftCommand command)
        {
            base.MoveLeftExecuted(command);
            if (transform.position.x >= 0)
            {
                Vector3 temp = transform.position;
                temp.x = temp.x - (200 * Time.deltaTime);
                transform.position = temp;
                transform.GetChild(1).rotation = new Quaternion(0, 180, 0, 0);
            }
            _animator.SetInteger("Stage", 1);
        }
        
        public override void MoveRightExecuted(MoveRightCommand command) {
            base.MoveRightExecuted(command);
            if (transform.position.x <= 2684)
            {
                Vector3 temp = transform.position;
                temp.x = temp.x + (200 * Time.deltaTime);
                transform.position = temp;
                transform.GetChild(1).rotation = new Quaternion(0, 0, 0, 0);
            }
            _animator.SetInteger("Stage", 1);
        }
        
        public override void MoveUpExecuted(MoveUpCommand command) {
            base.MoveUpExecuted(command);
            if (transform.position.y <= -95)
            {
                Vector3 temp = transform.position;
                temp.y = temp.y + (150 * Time.deltaTime);
                transform.position = temp;
            }
            _animator.SetInteger("Stage", 1);
        }
        
        public override void MoveDownExecuted(MoveDownCommand command) {
            base.MoveDownExecuted(command);
            if (transform.position.y >= -245)
            {
                Vector3 temp = transform.position;
                temp.y = temp.y - (150 * Time.deltaTime);
                transform.position = temp;
            }
            _animator.SetInteger("Stage", 1);
        }

        public override void MoveStopExecuted(MoveStopCommand command)
        {
            base.MoveStopExecuted(command);
            _animator.SetInteger("Stage", 0);
        }

        // ReSharper disable once RedundantOverridenMember
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as PrimeViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        // ReSharper disable once RedundantOverridenMember
        public override void Bind() {
            base.Bind();
            // Use this.Prime to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }

        private IDisposable MoveLeft;
        private IDisposable MoveRight;
        private IDisposable MoveUp;
        private IDisposable MoveDown;
        private IDisposable MoveStop;
        public override void AfterBind()
        {
            base.AfterBind();
            MoveLeft = Observable.EveryUpdate().Where(_ => Input.GetKey(KeyCode.A)).Subscribe(x =>
            {
                ExecuteMoveLeft();
            });
            MoveRight = Observable.EveryUpdate().Where(_ => Input.GetKey(KeyCode.D)).Subscribe(x =>
            {
                ExecuteMoveRight();
            });
            MoveUp = Observable.EveryUpdate().Where(_ => Input.GetKey(KeyCode.W)).Subscribe(x =>
            {
                ExecuteMoveUp();
            });
            MoveDown = Observable.EveryUpdate().Where(_ => Input.GetKey(KeyCode.S)).Subscribe(x =>
            {
                ExecuteMoveDown();
            });
            MoveStop = Observable.EveryUpdate().Where(_ => Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)).Subscribe(x =>
            {
                ExecuteMoveStop();
            });
        }

        void Update()
        {
            

            Vector3 temp1 = transform.GetChild(4).transform.position;
            temp1.x = Input.mousePosition.x + transform.position.x;
            temp1.y = Input.mousePosition.y + transform.position.y;
            transform.GetChild(4).transform.position = temp1;
        }


        public void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
        }

        private Animator _animator;
    }
}
