import { LevelTransaction } from "./level-transaction";
import { RemainingTransaction } from "./remaining-transaction";

export interface FuelTank
{
    id: number,
    name: string,
    number: number,
    capacity: number,
    currentAmount: number,
    stationId: number,
    updatedAt: Date,
    levelTransactions?: Array<LevelTransaction>
    remainingTransactions?: Array<RemainingTransaction>
}