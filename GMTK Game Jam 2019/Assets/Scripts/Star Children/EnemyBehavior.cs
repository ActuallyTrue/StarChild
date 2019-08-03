﻿public class EnemyBehavior : SimpleAI2D
{
    private bool isFiring = false;

    public float fireRange = 10f;

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        if (Player == null)
        {
            Player = FindObjectOfType<PlayerMove>().gameObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        if (base.tempDistance <= fireRange)
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }
    }

    bool ShouldFire()
    {
        return isFiring;
    }
}
