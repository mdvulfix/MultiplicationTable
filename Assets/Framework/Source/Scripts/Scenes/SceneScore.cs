﻿using UnityEngine;
using Framework.Core;

namespace Framework
{
    public class SceneScore : AScene
    {
        public static readonly string OBJECT_NAME = "Scene: Score";
        public static readonly ESceneBuildId BUILD_ID = ESceneBuildId.Score;
        
        
        [Header("Pages")]
        [SerializeField] private PageLoading pageLoading;
        [SerializeField] private PageScore pageScore;

        
        public override void Initialize()
        {
            SetParams(OBJECT_NAME);
            
            if(!DataCheck<IDataStats>(Stats))
                return;
            
            if(!DataCheck<IDataSceneLoading>(SceneLoading))
                return;
            
            Stats.GUID = 3;
            Stats.IsInitialized = true;
            
            if(isProject)
            {
                SetToCache(pageLoading);
                SetToCache(pageScore);
                    
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
            SceneLoading.PageDefault = pageScore;
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


    }
}