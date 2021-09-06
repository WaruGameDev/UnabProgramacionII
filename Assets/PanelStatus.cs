using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelStatus : MonoBehaviour
{
    public Quest questInfo;
    public TextMeshProUGUI questText;


    public void Update()
    {
        switch(QuestManager.instance.GetQuestState(questInfo.nombreQuest))
        {
            case Quest.QUEST_STATE.UNNASIGNED:
                questText.text = "La mision " + questInfo.nombreQuest + " no esta asignada";
                break;
            case Quest.QUEST_STATE.ASSIGNED:
                questText.text = "La mision " + questInfo.nombreQuest + " esta asignada";
                break;
            case Quest.QUEST_STATE.COMPLETE:
                questText.text = "La mision " + questInfo.nombreQuest + " esta completa";
                break;
        }
    }


}
