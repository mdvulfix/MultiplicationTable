﻿using UnityEngine;
using Core.Scene;
using Source.Scene.Page;

namespace Source.Scene
{
    public class SceneRunTime : AScene
    {
        public static readonly string OBJECT_NAME = "Scene: RunTime";
        public static readonly SceneIndex BUILD_ID = SceneIndex.RunTime;
        

        [Header("Pages")]
        [SerializeField] private PageLoading pageLoading;
        //[SerializeField] private PageRunTime pageRunTime;
        //[SerializeField] private PagePause pagePause;
        
        
        protected override void OnAwake()
        {
            var sceneController = new SceneControllerDefault();
            var parametrs = new SceneInitializationParams(sceneController);
            
            Initialize(parametrs);

        }
        
        protected override void OnStart()
        {

        }
        
        
        
        
        
        /*
        public override void Init()
        {
            SetParams(OBJECT_NAME);
            
            if(!DataCheck<IDataStats>(Stats))
                return;
            
            if(!DataCheck<IDataSceneLoading>(SceneLoading))
                return;
            
            Stats.GUID = 2;
            Stats.IsInitialized = true;
            
            if(isProject)
            {
                SetToCache(pageLoading);
                SetToCache(pageRunTime);
                SetToCache(pagePause);
                    
                foreach (var instance in Cache.GetAll())
                {
                    instance.Initialize();
                }
            }

            Log(Label, LogSuccessfulInitialize());
            //return this;
        }

        public override IConfigurable Configure()
        {
            
            SceneLoading.SceneBuildId = BUILD_ID;
            SceneLoading.PageDefault = pageRunTime;
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
