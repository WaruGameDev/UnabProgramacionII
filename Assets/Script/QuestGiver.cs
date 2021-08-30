using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public List<Quest> questsToGive;
    public List<Quest> questsToComplete;
    
    
    public void SetQuests()
    {     
        foreach(Quest q in questsToComplete)
        {
            
                QuestManager.instance.SetQuestState(q.nombreQuest, q.questState);
            
        }

        foreach(Quest q in questsToGive)
        {            
            
                QuestManager.instance.SetQuestState(q.nombreQuest, q.questState);
                        
        }
    }    
}
