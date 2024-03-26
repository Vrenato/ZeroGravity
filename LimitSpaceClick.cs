using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitSpaceClick : MonoBehaviour
{
    public int maxPresses = 3;
    private int currentPresses = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the current number of presses is less than the maximum allowed
            if (currentPresses < maxPresses)
            {
                // Perform the action you want when the space bar is pressed
                Debug.Log("Space bar pressed!");

                // Increment the count of presses
                currentPresses++;

                // Display the remaining allowed presses
                Debug.Log("Remaining presses: " + (maxPresses - currentPresses));
            }
            else
            {
                // Inform the player that no more presses are allowed
                Debug.Log("No more space bar presses allowed!");
                
            }
        }
    }
}
