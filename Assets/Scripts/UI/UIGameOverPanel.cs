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
    
    
    public class UIGameOverPanelData : QFramework.UIPanelData
    {
        public int DeathCountCurrent = 10;
    }
    
    public partial class UIGameOverPanel : QFramework.UIPanel
    {
        protected override void OnInit(QFramework.IUIData uiData)
        {
            mData = uiData as UIGameOverPanelData ?? new UIGameOverPanelData();
            // please add init code here

            TxtDeathCountCurrent.text = string.Format("当前通关死亡次数:{0}", mData.DeathCountCurrent);
            TxtDeathCountMin.text = string.Format("最小通关死亡次数:{0}", mData.DeathCountCurrent);

        }

        protected override void ProcessMsg(int eventId, QFramework.QMsg msg)
        {
            throw new System.NotImplementedException ();
        }
        

        
        protected override void OnOpen(QFramework.IUIData uiData)
        {
        }
        
        protected override void OnShow()
        {
        }
        
        protected override void OnHide()
        {
        }
        
        protected override void OnClose()
        {
        }
    }
}
