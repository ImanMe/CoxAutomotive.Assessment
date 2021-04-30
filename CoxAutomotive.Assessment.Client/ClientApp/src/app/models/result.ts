export class Deal {
  dealNumber: string;
  customerName: string;
  dealershipName: string;
  vehicle: string;
  price: string;
  date: string;
}

export class Result{
    mostSoldVehicle:string;
    headers:string[];
    deals:Deal[];
}
