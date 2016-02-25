MERGE INTO Categories AS Target 
USING (VALUES 
    (1, 'Achats'), 
    (2, 'Commerce'), 
    (3, 'Ressources Humaines'),
	(4, 'Conseil'),
	(5, 'IT'),
	(6, 'Communication/Media')
) 
AS Source (ID, Nom) 
ON Target.ID = Source.ID 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Nom) 
VALUES (Nom);


MERGE INTO Metiers AS Target
USING (VALUES 
    (1, 'Acheteur', 1), 
    (2, 'Directeur des achats', 1),
	(3, 'Assistant(e) commercial', 2),
	(4, 'Responsable de clientèle', 2),
	(5, 'Assistant(e) chargé de clientèle', 2),
	(6, 'Controleur de gestion', 2),
	(7, 'Responsable RH', 3),
	(8, 'Chargé(e) de recrutement', 3),
	(9, 'Directeur conseil', 4),
	(10, 'Directeur de développement', 4),
	(11, 'Développeur', 5),
	(12, 'Graphiste', 5),
	(13, 'Chef de projet web', 5),
	(14, 'Chef de projet digital', 6),
	(15, 'Chef de projet event', 6),
	(16, 'Chef de projet éditorial', 6)
)
AS Source (ID, Nom, CategorieId)
ON Target.ID = Source.ID
WHEN NOT MATCHED BY TARGET THEN
INSERT (Nom, CategorieId)
VALUES (Nom, CategorieId);