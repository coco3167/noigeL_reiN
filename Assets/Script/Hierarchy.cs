/*

Cellier -> "Vous êtes dans une pièce ressemblant à un cellier.\n\nDeux éléments vous sautent aux yeux :\n- Une grande et solide porte en bois.\n- Une imposante armoire semblant être faite du même bois."
    Ouvrir la Porte -> "Vous ne parvenez pas à l'ouvrir, elle semble fermée à clé.
                    -< [récupérer clé] "Vous utilisez la clé trouvée dans l'armoire et, sans surprise, la porte s'ouvre sans problème vers une autre salle bien plus grande où vous vous dirigez sans plus attendre."[Direction Piece2]

    Ouvrir l'armoire -> "L'armoire  s'ouvre sans difficulté laissant échapper un grincement étrange étrangement satisfaisant."
        Regarder dans l'armoire -> "En observant l'intérieur, vous remarquez l'ancienneté de l'endroit.\nL'ensemble est très poussiéreux et vous parvenez à peine à distinguer les différents éléments.
            Observer les livres -> "Les livres sont décrépis et tombent presque entièrement en poussière quand vous essayez d'intéragir avec.\Le temps et les insectes ont bien fait leur travail."
            Observer les vivres -> "Tout cela n'a plus aucun intérêt, même les boîtes de conserve sont dans un état de décomposition avancée."
            Observer la peluche -> "La peluche de Mia, elle a bien souffert. Vous vous rendez compte que la peluche est aussi abimée que votre mémoire car vous ne savez pas qui est Mia."
            Ouvrir le tiroit de gauche -> "Vous essayez de l'ouvrir mais quoi que vous tentiez le tiroir ne bouge pas d'un pouce.\nVous décidez de l'observer de plus proche et vous remarquez des symboles :\n\n<align=center>{Gestalt}<\align=center>\n\nVous décidez de ne pas y préter plus d'attention pour le moment et l'instant."
            Ouvrir le tiroir de droite -> "Le tiroir s'ouvre difficilement en n'arrêtant pas de grincer (un peu d'huile ne serait pas de refus).\nA l'intérieur vous trouvez des feuilles protégées des intempéries et du passage du temps ainsi qu'une clée n'ayant elle pas été épargnée."
                Lire les feuilles -> "{A écrire}"
                Récupérer la clé -> "La clé est bien rouillée mais nul doute qu'elle fonctionnera, vous la récupérez."[Porte -<]
            
Piste de danse -> "Alors même que vous n'avez pas fini de rentrer, la hauteur de la salle vous frappe.\nVous vous tenez dans ce qui ressemble à une piste de danse mais à l'étage se tient des tables, des chaises et l'unique autre sortie de l'endroit.\nVous cherchez de quoi monter à l'étage du regard et vous ne trouvez qu'une échelle brisée et deux chandeliers."
    Regarder les chandeliers -> "Les chandeliers sont sans nul doute un travail d'orfèvre, le travail des artisans les ayant réalisés sont visible même par un œil complétement néophyte.\nLe temps n'a que poli l'éclat poussièreux de ces pièces.\n\nL'une est écrasé au sol l'autre tient encore miraculeusement encore en l'air, elles semblent se compléter vous vous dites avant de ressentir un profond sentiment de solitude venant du rompu. Vous remarquez un levier en hauteur en dessous de l'autre."[Observer le levier -<]
    Regarder l'échelle -> "L'échelle devait autrefois servir à atteindre l'étage, les plus grands morceaux atteignent maintenant difficilement la hauteur de l'armoire du cellier."[Utiliser le levier -<]
    Observer le Levier -< "Le levier bien que non atteignable seulement en tendant le bras, si vous aviez de quoi vous surélevez grossièrement, vous pourriez l'abaisser. Sur le bois est gravé {TO DO}"
        Utiliser le levier -< "Vous récupérez le plus gros morceau d'échelle que vous puissiez trouver et l'installer afin d'enclencher le levier. Arrivée en bas, un clic se fait entendre et le chandelier encore en hauteur commence à descendre jusqu'à s'arrêter quelques centimètres au dessus du sol."[Monter sur le chandelier -<]
    Monter sur le chandelier -< ""

*/