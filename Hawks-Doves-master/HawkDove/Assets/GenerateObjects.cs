using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerateObjects : MonoBehaviour
{
    public InputField hawkInput;
    public InputField doveInput;
    public InputField foodInput;
    public InputField energyFoodInput;
    public InputField energyLossInput;
    public InputField deathInput;
    public InputField reprodInput;
    public InputField foodExpInput;

    public GameObject dove;
    public GameObject hawk;
    public GameObject food;

    private Vector3 min_val;
    private Vector3 max_val;

    private float x_axis;
    private float y_axis;
    private float z_axis;

    private Vector3 randPos;
    public bool canCreate;

    private void Start()
    {
        setCoord();
    }

    private void Update()
    {


    }

    public void onStart()
    {

        for (int i = 0; i < int.Parse(hawkInput.text); i++)
        {
            generateObject(hawk);
        }
        for (int j = 0; j < int.Parse(doveInput.text); j++)
        {
            generateObject(dove);
        }
        for (int k = 0; k < int.Parse(foodInput.text); k++)
        {
            generateObject(food);
        }
    }

        public void onStop()
        {
            Destroy(this.gameObject);
        }

        private void setCoord()
        {
            min_val = new Vector3(0, 0, 0);
            max_val = new Vector3(2, 2, 0);
        }

        private void generateObject(GameObject gameObject)
        {
            x_axis = UnityEngine.Random.Range(min_val.x, max_val.x);
            y_axis = UnityEngine.Random.Range(min_val.y, max_val.y);
            z_axis = 0;
            randPos = new Vector3(x_axis, y_axis, z_axis);
            if (canCreate)
            {
                Instantiate(gameObject, randPos, Quaternion.identity);
            }

        }

 }
