// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Common.JoinQueue;
using Content.Goobstation.Server.JoinQueue;
using Content.Goobstation.Server.Redial;
using Robust.Shared.IoC;

namespace Content.Goobstation.Server.IoC;

internal static class ServerGoobContentIoC
{
    internal static void Register()
    {
        var instance = IoCManager.Instance!;

        instance.Register<RedialManager>();
        instance.Register<IJoinQueueManager, JoinQueueManager>();
    }
}
