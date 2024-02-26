using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{  // 1
     public string labelText = "Collect All Items and Win";
     public int maxItems = 4;
     public bool showWinScreen = false;
     private int _itemsCollected = 0;
     public int Items
     {
         get { return _itemsCollected; }
         set {
             _itemsCollected = value;
             // 2
             if(_itemsCollected >= maxItems)
             {
                 labelText = "You've found all the items!";
                 showWinScreen = true;
             }
             else
             {
                 labelText = "Item found, only " + (maxItems = _itemsCollected) +" more to go!";

            }
         }
     }
      private int _playerHP = 3;
     public int HP
     {
         get { return _playerHP; }
         set {
             _playerHP = value;
             Debug.LogFormat("Lives: {0}", _playerHP);
         }
     }
      void OnGUI()
     { GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" +
             _playerHP);
        
         GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " +
            _itemsCollected);
         
         GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height /
            50, 300, 50), labelText);
             if (showWinScreen)
           {
             // 4
             if (GUI.Button(new Rect(Screen.width/2 - 100,
                Screen.height/2 - 50, 200, 100), "YOU WON!"))
             {
             }
 }
     }
}
