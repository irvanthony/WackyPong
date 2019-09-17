using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationDataa.csv";
    //Dictionary<string, float> values = new Dictionary<string, float>();

    // configuration data
    static float paddleMoveUnitsPerSecond = 10;
    static float ballImpulseForce = 5;
    static float ballLifeSeconds = 10;
    static float minSpawnDelay = 5;
    static float maxSpawnDelay = 10;
    static int standardPoints = 1;
    static int standardHits = 1;
    static int bonusPoints = 2;
    static int bonusHits = 2;
    static float freezerSeconds = 2;
    static float speedupSeconds = 2;
    static float speedupFactor = 2;
    static float standardBallSpawnProbability = 0.6f;
    static float bonusBallSpawnProbability = 0.2f;
    static float freezerPickupSpawnProbability = 0.1f;
    static float speedupPickupSpawnProbability = 0.1f;
    

    #endregion

    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    public float BallLifeSeconds
    {
        get { return ballLifeSeconds; }
    }

    public float MinSpawnDelay
    {
        get { return minSpawnDelay; }
    }

    public float MaxSpawnDelay
    {
        get { return maxSpawnDelay; }
    }

    public int StandardPoints
    {
        get { return standardPoints; }
    }

    public int StandardHits
    {
        get { return standardHits; }
    }

    public int BonusPoints
    {
        get { return bonusPoints; }
    }

    public int BonusHits
    {
        get { return bonusHits; }
    }

    public float FreezerSeconds
    {
        get { return freezerSeconds; }
    }

    public float SpeedupSeconds
    {
        get { return speedupSeconds; }
    }

    public float SpeedupFactor
    {
        get { return speedupFactor; }
    }

    public float StandardBallSpawnProbability
    {
        get { return standardBallSpawnProbability; }
    }

    public float BonusBallSpawnProbability
    {
        get { return bonusBallSpawnProbability; }
    }

    public float FreezerPickupSpawnProbability
    {
        get { return freezerPickupSpawnProbability; }
    }

    public float SpeedupPickupSpawnProbability
    {
        get { return speedupPickupSpawnProbability; }
    }
    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        StreamReader input = null;
        try
        {
            input = File.OpenText(Path.Combine(Application.streamingAssetsPath, ConfigurationDataFileName));
            string names = input.ReadLine();
            string values = input.ReadLine();

            SetConfigurationDataFields(values);

        }
        catch (Exception e)
        {

        }
        finally
        {
            if(input != null)
            {
                input.Close();
            }
        }

    }

    void SetConfigurationDataFields(string csvValues)
    {
        string[] values = csvValues.Split(',');

        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifeSeconds = float.Parse(values[2]);
        minSpawnDelay = float.Parse(values[3]);
        maxSpawnDelay = float.Parse(values[4]);
        standardPoints = int.Parse(values[5]);
        standardHits = int.Parse(values[6]);
        bonusPoints = int.Parse(values[7]);
        bonusHits = int.Parse(values[8]);
        freezerSeconds = float.Parse(values[9]);
        speedupSeconds = float.Parse(values[10]);
        speedupFactor = float.Parse(values[11]);
        standardBallSpawnProbability = float.Parse(values[12]);
        bonusBallSpawnProbability = float.Parse(values[13]);
        freezerPickupSpawnProbability = float.Parse(values[14]);
        speedupPickupSpawnProbability = float.Parse(values[15]);
    }

    #endregion
}
