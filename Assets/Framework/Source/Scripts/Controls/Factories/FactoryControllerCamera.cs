using System.Collections.Generic;
using UnityEngine;
using Framework.Core;

namespace Framework
{   
    [CreateAssetMenu(fileName = "FactoryControllerCamera", menuName = "Factories/Controllers/Camera")]
    public class FactoryControllerCamera : Factory
    {
        public override List<IControllerCamera> Get<IControllerCamera>()
        {
            var list = new List<IControllerCamera>()
            {
                (IControllerCamera)GetInstanceOf<ControllerCameraDefault>("Controller: Camera", Controller.PARENT_OBJECT_NAME).Initialize()
            };
            return list;
        }
    
    
    
    }
}
