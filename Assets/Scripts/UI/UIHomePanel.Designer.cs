// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace oneGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public partial class UIHomePanel
    {
        
        public const string NAME = "UIHomePanel";
        
        [SerializeField()]
        public Text TxtDeathCountMin;
        
        [SerializeField()]
        public Button BtnStartGame;
        
        [SerializeField()]
        public Text TxtVersion;
        
        [SerializeField()]
        public Button BtnAbout;
        
        private UIHomePanelData mPrivateData = null;
        
        public UIHomePanelData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new UIHomePanelData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            TxtDeathCountMin = null;
            BtnStartGame = null;
            TxtVersion = null;
            BtnAbout = null;
            mData = null;
        }
    }
}
