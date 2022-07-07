/////////////////////////////////////////////////////////////////////////////
// Copyright (C) 2021 Tegridy Ltd                                          //
// Author: Darren Braviner                                                 //
// Contact: db@tegridygames.co.uk                                          //
/////////////////////////////////////////////////////////////////////////////
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Tegridy.Boat
{
    public class TegridyBoatUIControlHolder : MonoBehaviour
    {
        public Button rudderLeft;
        public Button rudderRight;
        public Button throttleUp;
        public Button throttleDown;
        public Button direction;
        public Button close;
        public TextMeshProUGUI displayText;
    }
}