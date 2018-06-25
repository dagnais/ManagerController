using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerController : MonoBehaviour {
    public static ManagerController instance;

    #region Private Managers
    private PlayersManager          _playersManager;
    private TowerManager            _towerManager;
    private LeaderManager           _leaderManager;
    private UIManager               _uiManager;
    #endregion

    public ManagerController(){
        instance = this;
    }

    //Get Manager In Scene
    public T GetType<T>(Type param) where T: MonoBehaviour
    {
        Debug.Log(param);
        //Return PlayersManager
        if (param == typeof(PlayersManager))
        {
            if (_playersManager == null)
                _playersManager = FindObjectOfType<PlayersManager>();

            return (T)Convert.ChangeType(_playersManager == null ? null : _playersManager, typeof(T));
        }

        //Return TowerManager
        if (param== typeof(TowerManager))
        {
            if (_towerManager == null)
                _towerManager = FindObjectOfType<TowerManager>();

            return (T)Convert.ChangeType(_towerManager == null ? null : _towerManager, typeof(T));
        }

        //Return LeaderManager
        if (param == typeof(LeaderManager))
        {
            if (_leaderManager == null)
                _leaderManager = FindObjectOfType<LeaderManager>();

            return (T)Convert.ChangeType(_leaderManager == null ? null : _leaderManager, typeof(T));
        }

        //Return UIManager 
        if (param== typeof(UIManager))
        {
            if (_uiManager == null)
                _uiManager = FindObjectOfType<UIManager>();

            return (T)Convert.ChangeType(_uiManager == null ? null : _uiManager, typeof(T));
        }

        return (T)Convert.ChangeType(null, typeof(T));
    }
}
