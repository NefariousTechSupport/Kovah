# Havok Sucks

I've had to make some manual edits to make the thing compile, these are usually classes that exist in the executable but aren't caught by dump_metadata.py

## All Versions

### hkpWeldingUtility

This case is handled automatically by dump_metadata.py since the metadata is the same on all versions, though do double check when adding a new version

## hk_2011.2.0-r1

### Missing metadata

For some reason, `hkRootLevelContainerNamedVariant` is missing its names, simply replace the members with the following. Though do try and preserve the original offsets
```xml
<member type="TYPE_STRINGPTR" subtype="TYPE_VOID" arraysize="0" offset="0" name="name" />
<member type="TYPE_STRINGPTR" subtype="TYPE_VOID" arraysize="0" offset="4" name="className" />
<member type="TYPE_POINTER" subtype="TYPE_STRUCT" arraysize="0" offset="8" name="variant" class="hkReferencedObject" />
```

The same applies to `hkMemoryResourceContainer`, do the same with the following members, again trying to preserve the original offsets:
```xml
<member type="TYPE_STRINGPTR" subtype="TYPE_VOID" arraysize="0" offset="8" name="name" />
<member type="TYPE_POINTER" subtype="TYPE_STRUCT" arraysize="0" offset="12" name="parent" flags="SERIALIZE_IGNORED" class="hkMemoryResourceContainer" />
<member type="TYPE_ARRAY" subtype="TYPE_POINTER" arraysize="0" offset="16" name="resourceHandles" class="hkMemoryResourceHandle" />
<member type="TYPE_ARRAY" subtype="TYPE_POINTER" arraysize="0" offset="28" name="children" class="hkMemoryResourceContainer" />
```

## hk_2013.1.0-r1

### Shape Enums

Remove the enums `ShapeDispatchTypeEnum` and `ShapeInfoCodecTypeEnum` from the `hkenums` node and add the following to the `hkclasses` node:
Change references to `$loose.ShapeDispatchTypeEnum` to `hkcdShapeDispatchType.ShapeDispatchTypeEnum`
Change references to `$loose.ShapeInfoCodecTypeEnum` to `hkcdShapeInfoCodecType.ShapeInfoCodecTypeEnum`
```xml
<hkclass objectSize="1" describedVersion="0" numImplementedInterfaces="0" name="hkcdShapeDispatchType">
	<enums>
		<enum name="ShapeDispatchTypeEnum">
			<item value="0" name="CONVEX_IMPLICIT" />
			<item value="1" name="CONVEX" />
			<item value="2" name="HEIGHT_FIELD" />
			<item value="3" name="COMPOSITE" />
			<item value="4" name="USER" />
			<item value="5" name="NUM_DISPATCH_TYPES" />
		</enum>
	</enums>
</hkclass>
<hkclass objectSize="1" describedVersion="0" numImplementedInterfaces="0" name="hkcdShapeInfoCodecType">
	<enums>
		<enum name="ShapeInfoCodecTypeEnum">
			<item value="0" name="NULL_CODEC" />
			<item value="1" name="UFM358" />
			<item value="16" name="MAX_NUM_CODECS" />
		</enum>
	</enums>
</hkclass>
```