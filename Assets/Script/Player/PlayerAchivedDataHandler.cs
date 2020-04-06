﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAchivedDataHandler : MonoBehaviour
{
    public static PlayerAchivedDataHandler instance;
    [SerializeField] private PlayerAchivedDataScriptable _playerAChivedData;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void SetPlayerAchivedData(GameEnum.PlayerShipType shipType, GameEnum.GunType gunType)
    {
        AddPlayerShipTypeInAchievedList(shipType);
        AddPlayerGunTypeInAchivedList(gunType);
    }

    #region Ship

    private void AddPlayerShipTypeInAchievedList(GameEnum.PlayerShipType playerShipType)
    {
        if (_playerAChivedData == null)
            return;
        if(_playerAChivedData.achievedPlayerShipList == null)
        {
            _playerAChivedData.achievedPlayerShipList = new List<GameEnum.PlayerShipType>();
        }
        _playerAChivedData.achievedPlayerShipList.Add(playerShipType);
    }
    private List<GameEnum.PlayerShipType> GetAchievedPlayerShipList()
    {
        if (_playerAChivedData == null)
            return null;
        return _playerAChivedData.achievedPlayerShipList;
    }
    public bool IsShipTypeExistInAchievedShipList(GameEnum.PlayerShipType playerShipType)
    {
        if (GetAchievedPlayerShipList() == null)
            return false;
        for (int i = 0; i < GetAchievedPlayerShipList().Count; i++)
        {
            if (GetAchievedPlayerShipList()[i] == playerShipType)
                return true;
        }
        return false;
    }
    #endregion Ship


    #region Gun

    private void AddPlayerGunTypeInAchivedList(GameEnum.GunType gunType)
    {
        if (_playerAChivedData == null)
            return;
        if (_playerAChivedData.gunsList == null)
        {
            _playerAChivedData.gunsList = new List<GameEnum.GunType>();
        }
        _playerAChivedData.gunsList.Add(gunType);
    }
    private List<GameEnum.GunType> GetAchivedGunList()
    {
        if (_playerAChivedData == null)
            return null;
        return _playerAChivedData.gunsList;
    }

    public bool IsGunTypeExistInAchievedGunList(GameEnum.GunType gunType)
    {
        if (GetAchivedGunList() == null)
            return false;
        for(int i=0;i< GetAchivedGunList().Count; i++)
        {
            if (GetAchivedGunList()[i] == gunType)
                return true;
        }
        return false;
    }

    #endregion Gun

}
