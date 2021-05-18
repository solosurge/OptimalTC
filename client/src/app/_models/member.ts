import { Photo } from "./photo";

export interface Member {
    id: number;
    userName: string;
    photoUrl: string;
    knownAs: string;
    created: Date;
    lastActive: Date;
    information: string;
    city: string;
    photos: Photo[];
  }
  
