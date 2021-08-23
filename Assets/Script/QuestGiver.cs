using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public List<Quest> questsToGive;
    
    
    public void SetQuests()
    {
        foreach(Quest q in questsToGive)
        {            
            QuestManager.instance.SetQuestState(q.nombreQuest, q.questState);
        }
    }    
}
