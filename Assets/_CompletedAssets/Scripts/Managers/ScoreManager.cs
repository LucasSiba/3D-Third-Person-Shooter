using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
		
        public static int score;        // The player's score.
		public int ramboscorelimit;
		public GameObject ramboMessage;

		public static bool RamboMode = false;

        Text text;                      // Reference to the Text component.


        void Awake ()
        {
			RamboMode = false;

            // Set up the reference.
            text = GetComponent <Text> ();

            // Reset the score.
            score = 0;
        }


        void Update ()
        {
			if (score >= ramboscorelimit) {
				RamboMode = true;
				text.color = Color.red;
				ramboMessage.SetActive (true);
				PlayerShooting.damagePerShot = 25;
				PlayerShooting.timeBetweenBullets = 0.08f; 
			}

			if (RamboMode == true) {
				text.text = "Rambo Score: " + score + "!!!";
			} else { 
				// Set the displayed text to be the word "Score" followed by the score value.
				text.text = "Score: " + score;
			}

        }
    }
}