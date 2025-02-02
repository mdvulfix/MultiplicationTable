﻿using System;
using System.Collections.Generic;
using UnityEngine;
using Core.Scene;
using Source.Scene.Page;

namespace Source.Scene
{
    public class SceneCore : AScene
    {
        private readonly string OBJECT_NAME = "Scene: Menu";
        private readonly SceneIndex BUILD_INDEX = SceneIndex.Core;
        
        
        [Header("Pages")]
        [SerializeField] private PageLoading pageLoading;
 

        protected override void OnAwake()
        {
            var sceneController = new SceneControllerDefault();
            var parametrs = new SceneInitializationParams(sceneController);
            
            Initialize(parametrs);

        }
        

        protected override void OnStart()
        {
            Activate(pageLoading, true);
        }
        

        
        /*
        public override void Init(IDataScene data)
        {
            SetParams(OBJECT_NAME);
            
            if(!DataCheck<IDataStats>(Stats))
                return;
            
            if(!DataCheck<IDataLoading>(SceneLoading))
                return;
            
            
            Stats.GUID = 1;
            
            
            if(isProject)
            {
                
                List<IPage> initializationList = new List<IPage>(3);
                
                initializationList.Add(pageLoading);
                initializationList.Add(pageLogin);
                initializationList.Add(pageMenu);
                    
                foreach (var instance in initializationList)
                {
                    instance.Initialize();
                    SetToCache(instance);
                }

            }

            Stats.IsInitialized = true;
            Log(Label, LogSuccessfulInitialize());
            //return this;
        }

        public override IConfigurable Configure()
        {
            
            SceneLoading.SceneBuildId = BUILD_ID;
            SceneLoading.PageDefault = pageLogin;
            SceneLoading.OnLoadCallback = null;

            if(Cache.IsEmpty())
            {
                LogWarning(Label, LogFailedConfigure("Cache is empty!"));
                return null;
            }
            else
            {
                foreach (var instance in Cache.GetAll())
                {
                    instance.Configure();
                }
            }
            
            Stats.IsConfigerd = true;
            Log(Label, LogSuccessfulConfigure());
            return this;
        }
        */
    }
}
