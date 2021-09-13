using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestDetectAndChange : MonoBehaviour
{
    public string nameQuest;
    public Quest.QUEST_STATE newQuestState;
    public Quest.QUEST_STATE requireState;
    public UnityEvent onChangeQuest;

    public void ChangeQuestStatus()
    {
        if (QuestManager.instance.GetQuestState(nameQuest) == requireState)
        {
            QuestManager.instance.SetQuestState(nameQuest, newQuestState);
            onChangeQuest?.Invoke();
        }
       
    }
}
