﻿using Robust.Shared.Serialization;

namespace Content.Shared._NewParadise.TTS;

[Serializable, NetSerializable]
// ReSharper disable once InconsistentNaming
public sealed class PlayTTSEvent(NetEntity uid, byte[] data, bool boostVolume, bool? isWhisper = null) : EntityEventArgs
{
    public NetEntity Uid { get; } = uid;

    public byte[] Data { get; } = data;

    public bool BoostVolume { get; } = boostVolume;

    public bool? IsWhisper { get; } = isWhisper;
}

[Serializable, NetSerializable]
// ReSharper disable once InconsistentNaming
public sealed class PlayTTSGlobalEvent(byte[] data, bool boostVolume) : EntityEventArgs
{
    public byte[] Data { get; } = data;

    public bool BoostVolume { get; } = boostVolume;
}

[Serializable, NetSerializable]
public sealed class PlayPreviewTTSEvent : EntityEventArgs
{
    public PlayPreviewTTSEvent(byte[] data)
    {
        Data = data;
    }

    public byte[] Data { get; }
}
