﻿using LevelGeneration;
using UnityEngine;

namespace Hikaria.ItemMarker.Handlers.Markers
{
    public class LG_HSUActivatorMarker : ItemMarkerBase
    {
        public override void SetupNavMarker(Component comp)
        {
            m_hsuActivator = comp.Cast<LG_HSUActivator_Core>();
            m_marker = GuiManager.NavMarkerLayer.PrepareGenericMarker(comp.gameObject);
            m_markerColor = new Color(0.467f, 0.098f, 1f);
            m_markerVisibleUpdateMode = ItemMarkerVisibleUpdateModeType.Zone;
            m_markerStyle = eNavMarkerStyle.PlayerPingGenerator;
            m_terminalItem = m_hsuActivator.m_terminalItem.Cast<LG_GenericTerminalItem>();
            m_markerTitle = m_terminalItem.TerminalItemKey;

            base.SetupNavMarker(comp);
        }

        private LG_HSUActivator_Core m_hsuActivator;
    }
}