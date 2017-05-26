using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Completed
{


    public class PlayerBars : MonoBehaviour
    {
        public Stat healthBarValue;
        public static PlayerBars instance = null;
        //[SerializeField]
        public Stat infectionBarValue;





        private void Awake()
        {
            
           
            //Check if instance already exists
            if (instance == null)

                //if not, set instance to this
                instance = this;

            //If instance already exists and it's not this:
            else if (instance != this)

                //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
                Destroy(gameObject);

            //Sets this to not be destroyed when reloading scene
            DontDestroyOnLoad(gameObject);
            healthBarValue.Initialize();
			infectionBarValue.Initialize ();
        }

        private void Update()
        {
        }
    }
}
