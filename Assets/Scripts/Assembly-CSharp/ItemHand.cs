using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (GC.GetComponent<GameControllerScript>().item[GC.GetComponent<GameControllerScript>().itemSelected])
        {
            case 0:
                switchSprite = Nothing;
                break;
            case 1:
                switchSprite = ZestBar;
                break;
            case 2:
                switchSprite = YellowDoorLock;
                break;
            case 3:
                switchSprite = Key;
                break;
            case 4:
                switchSprite = BSODA;
                break;
            case 5:
                switchSprite = Quarter;
                break;
            case 6:
                switchSprite = Tape;
                break;
            case 7:
                switchSprite = AlarmClock;
                break;
            case 8:
                switchSprite = NoSquee;
                break;
            case 9:
                switchSprite = Scissors;
                break;
            case 10:
                switchSprite = Boots;
                break;
            default:
                switchSprite = Nothing;
                break;
        }
        base.GetComponent<SpriteRenderer>().sprite = switchSprite;
    }

    public Component sprite;
    public GameObject GC;
    private Sprite switchSprite;
    // i hate the way im making this work but i dont know enough about unity to do it differently
    public Sprite Nothing;
    public Sprite ZestBar;
    public Sprite YellowDoorLock;
    public Sprite Key;
    public Sprite BSODA;
    public Sprite Quarter;
    public Sprite Tape;
    public Sprite AlarmClock;
    public Sprite NoSquee;
    public Sprite Scissors;
    public Sprite Boots;
}
