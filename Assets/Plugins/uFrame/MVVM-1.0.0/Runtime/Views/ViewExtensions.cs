using System;
using uFrame.Kernel;
using uFrame.MVVM.Events;
using uFrame.MVVM.Services;
using uFrame.MVVM.ViewModels;
using UnityEngine;
using Object = UnityEngine.Object;

namespace uFrame.MVVM.Views
{
    public static class ViewExtensions
    {
        public static ViewBase GetView(this GameObject go)
        {
            return go.GetComponent<ViewBase>();
        }

        public static T GetView<T>(this GameObject go) where T : class
        {
            return GetView(go) as T;
        }

        public static ViewBase GetView(this Collision go)
        {
            return GetView(go.collider);
        }

        public static T GetView<T>(this Collision go) where T : class
        {
            return GetView(go.collider) as T;
        }

        public static ViewBase GetView(this Transform go)
        {
            return go.GetComponent<ViewBase>();
        }

        public static T GetView<T>(this Transform go) where T : class
        {
            return GetView(go) as T;
        }

        public static ViewBase GetView(this Collider go)
        {
            return go.GetComponent<ViewBase>();
        }

        public static T GetView<T>(this Collider go) where T : class
        {
            return GetView(go) as T;
        }

        public static ViewBase GetView(this MonoBehaviour go)
        {
            if (go == null) return null;
            return go.GetComponent<ViewBase>();
        }

        public static T GetView<T>(this MonoBehaviour go) where T : class
        {
            return GetView(go) as T;
        }

        public static ViewModel GetViewModel(this GameObject go)
        {
            var view = GetView(go);
            if (view == null)
                return null;
            return view.ViewModelObject;
        }

        public static T GetViewModel<T>(this GameObject go) where T : class
        {
            return GetViewModel(go) as T;
        }

        public static T GetViewModel<T>(this Collision go) where T : class
        {
            return GetViewModel(go.collider) as T;
        }

        public static ViewModel GetViewModel(this Transform go)
        {
            var view = GetView(go);
            if (view == null)
                return null;
            return view.ViewModelObject;
        }

        public static T GetViewModel<T>(this Transform go) where T : class
        {
            return GetViewModel(go) as T;
        }

        public static ViewModel GetViewModel(this Collider go)
        {
            var view = GetView(go);
            if (view == null)
                return null;
            return view.ViewModelObject;
        }

        public static ViewModel GetViewModel(this Collision go)
        {
            var view = GetView(go.collider);
            if (view == null)
                return null;
            return view.ViewModelObject;
        }

        public static T GetViewModel<T>(this Collider go) where T : class
        {
            return GetViewModel(go) as T;
        }

        public static ViewModel GetViewModel(this MonoBehaviour go)
        {
            var view = GetView(go);
            if (view == null)
                return null;
            return view.ViewModelObject;
        }

        public static T GetViewModel<T>(this MonoBehaviour go) where T : class
        {
            return GetViewModel(go) as T;
        }

        [Obsolete]
        public static ViewBase InitializeView(this Transform parent, string name, ViewModel model, GameObject viewObject,
            string identifier = null)
        {
//        var view = viewObject.GetComponent<ViewBase>();

//        if (view == null)
//        {
//            Object.Destroy(viewObject);
//            throw new Exception(string.Format("View Object does not have a 'View<{0}>' component.", model.GetType().Name));
//        }
//        if (!string.IsNullOrEmpty(identifier))
//        {
//            view.Identifier = identifier;
//            if (model != null)
//            {
//                model.Identifier = identifier;
//            }
//        }
//        else if (model != null && !string.IsNullOrEmpty(model.Identifier))
//        {
//            view.Identifier = model.Identifier;
//        }
//#if (UNITY_4_6 || UNITY_5_0)
//        view.transform.SetParent(parent,false);
//#else
//        view.transform.parent = parent;
//#endif
//        // Pre cache the parent view
//       // view.ParentView = view.ParentView;
//        view.ViewName = name;

//        if (model != null)
//        {
//            model.Identifier = view.Identifier;
//            view.OverrideViewModel = false;
//         //   view.ForceResolveViewModel = false;   
//            view.ViewModelObject = model;
//            view.SetupBindings();
//        }

//        return view;
            return null;
        }

        public static ViewBase InstantiateView(this Transform parent, GameObject prefab, ViewModel model,
            string identifier = null)
        {
            return InstantiateView(parent, prefab, model, Vector3.zero, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model,
            string identifier = null)
        {
            return InstantiateView(parent, viewName, model, Vector3.zero, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model, Vector3 position,
            string identifier = null)
        {
            return InstantiateView(parent, viewName, model, position, Quaternion.identity, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, string viewName, ViewModel model, Vector3 position,
            Quaternion rotation, string identifier = null)
        {
            return InstantiateView(parent, ViewService.ViewResolver.FindView(viewName), model, position, rotation,
                identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, GameObject prefab, ViewModel model,
            Vector3 position, string identifier = null)
        {
            return InstantiateView(parent, prefab, model, position, Quaternion.identity, identifier);
        }

        public static ViewBase InstantiateView(
            this Transform parent,
            IScene parentScene,
            GameObject prefab,
            ViewModel model,
            string identifier = null)
        {
            var command = new InstantiateViewCommand()
            {
                Identifier = identifier,
                ViewModelObject = model,
                Scene = parentScene,
                Prefab = prefab
            };
            uFrameKernel.EventAggregator.Publish(command);
            command.Result.transform.SetParent(parent);
            command.Result.transform.localPosition = Vector3.zero;
            command.Result.transform.localScale = Vector3.one;
            command.Result.transform.localEulerAngles = Vector3.zero;
            return command.Result;
        }

        public static ViewBase InstantiateView(this Transform parent,
            GameObject prefab,
            ViewModel model,
            Vector3 position,
            Quaternion rotation,
            string identifier = null)
        {
            var parentScene = parent.GetComponent<Scene>();
            var command = new InstantiateViewCommand()
            {
                Identifier = identifier,
                ViewModelObject = model,
                Scene = parentScene,
                Prefab = prefab
            };
            uFrameKernel.EventAggregator.Publish(command);
            command.Result.transform.position = position;
            command.Result.transform.rotation = rotation;
            return command.Result;
        }

        public static ViewBase InstantiateView(this Transform parent, ViewModel model, string identifier = null)
        {
            return InstantiateView(parent, model, Vector3.zero, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, ViewModel model, Vector3 position,
            string identifier = null)
        {
            return InstantiateView(parent, model, position, Quaternion.identity, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, ViewModel model, Vector3 position,
            Quaternion rotation, string identifier = null)
        {
            return InstantiateView(parent, ViewService.ViewResolver.FindView(model), model, position, rotation,
                identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, IScene parentScene, ViewModel model, string identifier = null)
        {
            return InstantiateView(parent, parentScene, ViewService.ViewResolver.FindView(model), model, identifier);
        }

        public static ViewBase InstantiateView(this Transform parent, IScene parentScene, string viewName, ViewModel model, string identifier = null)
        {
            return InstantiateView(parent, parentScene, ViewService.ViewResolver.FindView(viewName), model, identifier);
        }

        public static bool IsView<TView>(this Transform go) where TView : ViewBase
        {
            if (go == null) return false;
            var c = go.GetComponent<TView>();
            return c != null;
        }

        public static bool IsView<TView>(this GameObject go) where TView : ViewBase
        {
            if (go == null) return false;
            var c = go.GetComponent<TView>();
            return c != null;
        }
    }
}