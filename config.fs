[AID_VENDOR_QTI_DIAG]
value:2901

[AID_VENDOR_QRTR]
value:2906

[AID_VENDOR_SPAY]
value:5279

[system/vendor/bin/hw/android.hardware.bluetooth@1.0-service-qti]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_ADMIN BLOCK_SUSPEND

[system/vendor/bin/hw/android.hardware.bluetooth@1.0-service-qti-lazy]
mode: 0755
user: AID_SYSTEM
group: AID_SYSTEM
caps: NET_ADMIN BLOCK_SUSPEND

[system/vendor/bin/wcnss_filter]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: BLOCK_SUSPEND

[vendor/bin/wcnss_filter]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: BLOCK_SUSPEND

[vendor/bin/hw/android.hardware.bluetooth@1.0-service-qti]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: NET_ADMIN BLOCK_SUSPEND

[vendor/bin/hw/android.hardware.bluetooth@1.0-service-qti-lazy]
mode: 0755
user: AID_BLUETOOTH
group: AID_BLUETOOTH
caps: NET_ADMIN BLOCK_SUSPEND

[prism/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[optics/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[metadata/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[dsp/]
mode: 0771
user: AID_MEDIA
group: AID_MEDIA
caps: 0

[efs/]
mode: 0771
user: AID_SYSTEM
group: AID_RADIO
caps: 0

[carrier/]
mode: 0771
user: AID_SYSTEM
group: AID_RADIO
caps: 0

[dqmdbg/]
mode: 0770
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[omr/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[spu/]
mode: 0770
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[keydata/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0

[keyrefuge/]
mode: 0771
user: AID_SYSTEM
group: AID_SYSTEM
caps: 0
