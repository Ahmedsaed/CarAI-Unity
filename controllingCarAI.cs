using UnityEngine;

public class controllingCarAI : MonoBehaviour
{
    //This is an example script. To show you how to control the AI using script(At Runtime)

    public CarAI carAI;
    
    void variables()
    {
        //1- Patrol = true && Patrol = false
        carAI.Patrol = true;
        //or
        carAI.Patrol = false;

        //2- Set the maximum steering angle
        carAI.MaxSteeringAngle = 45;

        //3- Set the maximum RPM(Speed)
        carAI.MaxRPM = 150;

        //4- Set the NavMesh Layer name
        //carAI.NavMeshLayer = "LayerName";

        //5- Show Gizmos
        carAI.ShowGizmos = true;
        //or hide Gizmos
        carAI.ShowGizmos = false;

        //6- Allow thr car to move
        carAI.move = true;
        //or apply brakes
        carAI.move = false;

        //8- Set maximum attempts
        //carAI.MaxAttempts = 50;

        //9- Set delay
        //carAI.delay = 3;
    }

    void Methods()
    {
        //2- Creates a path to a new random Destination
        carAI.RandomPath();

        //3- Creates a path to a new custom Destination
        carAI.CustomPath(gameObject.transform);
    }
}
