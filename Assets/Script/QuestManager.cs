using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public string nombreQuest;
    public enum QUEST_STATE
    {
        UNNASIGNED =0,
        ASSIGNED = 1,            
        COMPLETE = 2
    }    
    public QUEST_STATE questState;
}


public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public List<Quest> quests;
    public Transform panelMisiones;
    public GameObject panelMisionesInfo;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        foreach(Quest q in quests)
        {
            GameObject questInfo = Instantiate(panelMisionesInfo, panelMisiones);
            questInfo.GetComponent<PanelStatus>().questInfo.nombreQuest = q.nombreQuest;
            questInfo.GetComponent<PanelStatus>().questInfo.questState = q.questState;
        }
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
