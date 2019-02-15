using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdem : MonoBehaviour
{
    
    enum cardCoeff { none =1 , pair =10 , twopair = 100 , Fullhouse = 1000 ,Four =10000 , Straight = 100000};
    ArrayList m_BossScore = new ArrayList();
    ArrayList m_BossCard = new ArrayList();
    public int[] Card1 = new int[] {1,2,3,4,5};
    public int[] Card2 = new int[] {2,3,4,5,6};
    public int[] Card3 = new int[] {5,5,5,5,1};
    public int[] Card4 = new int[] {4,4,4,3,3};
    public int[] Card5 = new int[] {3,3,5,2,1};
    public int[] Card6 = new int[] {1,4,5,6,2 };
    //牌庫 5張1 4張2 3張3 2張4 1張5 
    List<int> AllCard = new List<int> {1,1,1,1,1,
                                       2,2,2,2,
                                       3,3,3,
                                       4,4,
                                       5

    };
    //卡片分數 15 20 30 40 50

    List<int> MyCard = new List<int> { };

    // Start is called before the first frame update
    void Start()
    {
        m_BossCard = new ArrayList();
        m_BossCard.Add(Card1);
        m_BossCard.Add(Card2);
        m_BossCard.Add(Card3);
        m_BossCard.Add(Card4);
        m_BossCard.Add(Card5);
    }

    void compareCard()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
