﻿using Framework.Core;

namespace Framework
{
    public class PageRunTime : APage
    {
        public static readonly string OBJECT_NAME = "Page: RunTime";
        
        public override void Initialize()
        {
            SetSceneObject(OBJECT_NAME);
            Activate(false);

            Log(Label, "was sucsessfully initialized");
            //return this;

        }

        public override IConfigurable Configure()
        {
            Log(Label, "was sucsessfully configured");
            return this;
        }
    }
}