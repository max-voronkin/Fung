import { HeightUnit } from "../enums/height-unit";
import { VolumeUnit } from "../enums/volume-unit";

export interface Settings 
{
    id: number,
    heightUnit: HeightUnit,
    volumeUnit: VolumeUnit
    userID: number
}