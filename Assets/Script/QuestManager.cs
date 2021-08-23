using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public string nombreQuest;
    public enum QUEST_STATE
    {
        UNNASIGNED,
        ASSIGNED,            
        COMPLETE
    }
    public QUEST_STATE questState;
}


public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public List<Quest> quests;

    private void Awake()
    {
        instance = this;
    }
    // saber en que estado esta una quest especifica.
    public Quest.QUEST_STATE GetQuestState(string nameQuest)
    {
        Quest.QUEST_STATE qState = Quest.QUEST_STATE.UNNASIGNED;
        foreach (Quest q in quests)
        {
            if (q.nombreQuest == nameQuest)
            {
                qState = q.questState;
            }
        }
        return qState;
    }
    // que cambie el estado de la quest
    public void SetQuestState(string nameQuest, Quest.QUEST_STATE newQuestState)
    {
        foreach(Quest q in quests)
        {
            if(q.nombreQuest == nameQuest)
            {
                q.questState = newQuestState;
            }
        }
    }

    public void ResetQuest()
    {
        foreach(Quest q in quests)
        {
            q.questState = Quest.QUEST_STATE.UNNASIGNED;
        }
    }

    //private void Update()
    //{
    //    if(Input.GetButtonDown("Jump"))
    //    {
    //        print(GetQuestState("Pepito"));
    //        SetQuestState("Juanito", Quest.QUEST_STATE.ASSIGNED);
    //    }
    //}

}
