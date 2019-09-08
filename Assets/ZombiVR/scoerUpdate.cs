using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class scoerUpdate : MonoBehaviour
    {
        public Text score;
        float points = 0f;

        public void updateScore(float addPoints)
        {
            points += addPoints;
            score.text = score.ToString();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

