import { LevelTransaction } from "src/models/Entities/level-transaction"
import { RemainingTransaction } from "src/models/Entities/remaining-transaction"

export interface FuelTankInfoDTO
{
    id: number,
    name: string,
    number: number,
    capacity: number,
    currentAmount: number,
    stationId: number,
    updatedAt: Date,
    stationName: string,
    levelTransactions?: Array<LevelTransaction>
    remainingTransactions?: Array<RemainingTransaction>
}