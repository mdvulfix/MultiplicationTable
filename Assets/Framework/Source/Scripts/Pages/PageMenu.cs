using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Framework.Core;
using Framework.Core.Handlers;

namespace Framework
{
    public class PageMenu : APage
    {
        public static readonly string OBJECT_NAME = "Page: Menu";

        public override void Initialize()
        {
            SetParams(OBJECT_NAME);
            
            DataStats.ID = 2;
            DataStats.IsInitialized = true;

            Log(Label, "was sucsessfully initialized");
            //return this;

        }

        public override IConfigurable Configure()
        {
            DataStats.ID = 2;

            DataAnimation.UseAnimation = true;
            DataAnimation.Animator = GetComponent<Animator>();
            DataAnimation.CurrentState = ANIMATOR_STATE_NONE;
            DataAnimation.TargetState = ANIMATOR_STATE_NONE;

            //Activate(false);

            DataStats.IsConfigerd = true;
            Log(Label, "was sucsessfully configured");

            return this;
        }
    } 
}
