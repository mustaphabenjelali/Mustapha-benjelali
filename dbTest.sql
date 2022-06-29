create database dbScolaireTransports
use dbScolaireTransports

CREATE TABLE Eleve(
   CodeMassar NVARCHAR(15),
   NomEleve NVARCHAR(20),
   PrenomEleve NVARCHAR(20),
   Sexe NVARCHAR(20),
   DateNaissanceEleve DATE,
   TelephoneEleve NVARCHAR(20),
   EmailEleve NVARCHAR(50),
   AdresseEleve NVARCHAR(50),
   DateInscriptionEleve DATE,
   PRIMARY KEY(CodeMassar)
);

select * from Eleve
insert into Eleve values('H547841012',N'الناصري',N'دعاء',N'انثى','01/05/2008','0606874101','douaeNassiri@gmail.com',N'الناظور','02/07/2021')


CREATE TABLE Ecole(
   idEcole NVARCHAR(15),
   NomEcole NVARCHAR(50),
   AdresseEcole NVARCHAR(50),
   Degre NVARCHAR(50),
   PRIMARY KEY(idEcole)
);
select * from Ecole
insert into Ecole values('T-H',N'ثانوية طه حسين التاهلية',N'جعدار',N'الثانوي')

CREATE TABLE Membre_Association(
   CinMA NVARCHAR(10),
   NomMA NVARCHAR(20),
   PrenomMA NVARCHAR(20),
   RoleMA NVARCHAR(20),
   DateNaissanceMA DATE,
   TelephoneMA NVARCHAR(15),
   EmailMA NVARCHAR(50),
   DateDebutMA DATE,
   PRIMARY KEY(CinMA)
);
select * from Membre_Association
insert into Membre_Association values('S874520',N'الشركي',N'عبد الحميد ',N'رئيس الجمعية','12/05/1968','0677458741','hamidChargui@gmail.com','01/05/2010')

CREATE TABLE NiveauScolaire(
   idNiveauScolaire NVARCHAR(15),
   LibelleNiveau NVARCHAR(50),
   PRIMARY KEY(idNiveauScolaire)
);
select * from NiveauScolaire
insert into NiveauScolaire values('10',N'جذع مشترك')


CREATE TABLE Annee(
   AnneeScolaire NVARCHAR(50),
   PRIMARY KEY(AnneeScolaire)
);
select * from Annee
insert into Annee values('2021-2022')


CREATE TABLE Bus_Scolaire(
   MatriculeBus NVARCHAR(15),
   Capacite INT,
   Modele NVARCHAR(50),
   Marque NVARCHAR(50),
   Carburant NVARCHAR(20),
   PRIMARY KEY(MatriculeBus)
);
select * from Bus_Scolaire
insert into Bus_Scolaire values('587452-50',25,'Renault 2014','Renault',N'اصونص-Essance')


CREATE TABLE Paiment(
   NumeroRecuPaiment INT identity(1,1),
   DateOperation DATE,
   Montant DECIMAL,
   Commentaire NVARCHAR(50),
   Paidway NVARCHAR(50),
   AnneeScolaire NVARCHAR(50) NOT NULL,
   CodeMassar NVARCHAR(15) NOT NULL,
   PRIMARY KEY(NumeroRecuPaiment),
   FOREIGN KEY(AnneeScolaire) REFERENCES Annee(AnneeScolaire),
   FOREIGN KEY(CodeMassar) REFERENCES Eleve(CodeMassar)
);
select * from Paiment
insert into Paiment values('01/03/2022',110,N'الناصري دعاء',N'نقدا','2021-2022','H547841012')


CREATE TABLE Sortie(
   NumeroRecuSortie INT identity(1,1),
   MontantSortie DECIMAL,
   TypeSortie NVARCHAR(20),
   DateOperation DATE,
   CinMA NVARCHAR(10),
   AnneeScolaire NVARCHAR(50),
   MatriculeBus NVARCHAR(15),
   PRIMARY KEY(NumeroRecuSortie),
   FOREIGN KEY(CinMA) REFERENCES Membre_Association(CinMA),
   FOREIGN KEY(AnneeScolaire) REFERENCES Annee(AnneeScolaire),
   FOREIGN KEY(MatriculeBus) REFERENCES Bus_Scolaire(MatriculeBus)
);
select * from Sortie
insert into Sortie values(680,N'البنزين','02/02/2022','S874520','2021-2022','587452-50')

CREATE TABLE AnneeScolaire(
   CodeMassar NVARCHAR(15),
   idEcole NVARCHAR(15),
   idNiveauScolaire NVARCHAR(15),
   AnneeScolaire NVARCHAR(50),
   MatriculeBus NVARCHAR(15),
   PRIMARY KEY(CodeMassar, idEcole, idNiveauScolaire, AnneeScolaire, MatriculeBus),
   FOREIGN KEY(CodeMassar) REFERENCES Eleve(CodeMassar),
   FOREIGN KEY(idEcole) REFERENCES Ecole(idEcole),
   FOREIGN KEY(idNiveauScolaire) REFERENCES NiveauScolaire(idNiveauScolaire),
   FOREIGN KEY(AnneeScolaire) REFERENCES Annee(AnneeScolaire),
   FOREIGN KEY(MatriculeBus) REFERENCES Bus_Scolaire(MatriculeBus)
);

CREATE TABLE Conduire(
   CinMA NVARCHAR(10),
   MatriculeBus NVARCHAR(15),
   DateAttribution DATE,
   PRIMARY KEY(CinMA, MatriculeBus),
   FOREIGN KEY(CinMA) REFERENCES Membre_Association(CinMA),
   FOREIGN KEY(MatriculeBus) REFERENCES Bus_Scolaire(MatriculeBus)
);
select * from Conduire