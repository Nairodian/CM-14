﻿using Content.Shared.Whitelist;
using Robust.Shared.GameStates;

namespace Content.Shared._CM14.Hands;

[RegisterComponent, NetworkedComponent]
[Access(typeof(CMHandsSystem))]
public sealed partial class WhitelistPickupComponent : Component
{
    [DataField]
    public EntityWhitelist Whitelist = new();
}
