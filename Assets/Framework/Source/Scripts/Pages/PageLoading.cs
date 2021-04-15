﻿using UnityEngine;
using Framework.Core;

namespace Framework
{

    public class PageLoading : APage
    {
        public static readonly string OBJECT_NAME = "Page: Loading";
        
        
        public override void Initialize()
        {
            SetSceneObject(OBJECT_NAME);
            

            Log(Label, "was sucsessfully initialized");
            //return this;

        }

        public override IConfigurable Configure()
        {
            Activate(false);
            
            Log(Label, "was sucsessfully configured");
            return this;
        }
    }
}
