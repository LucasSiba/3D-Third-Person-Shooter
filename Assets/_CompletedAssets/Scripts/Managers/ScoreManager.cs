using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
		
        public static int score;        // The player's score.
		public static bool RamboMode = false;
		public int ramboscorelimit;
		public GameObject ramboMessage;

		public GameObject backgroundMusic;
		public GameObject ramboMusic;

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
				EnemyHealth.explosionForce = 500;

				AudioSource backgroundAs = backgroundMusic.GetComponent <AudioSource> ();
				backgroundAs.Stop ();

				AudioSource ramboAs = ramboMusic.GetComponent <AudioSource> ();
				ramboAs.Play ();
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