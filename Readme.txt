# UI_RPG_N


Setter.(Inkapsulacija)
1. GameManager.cs
2. player.ActiveWeapon = availableWeapons[randomIndex];
3. Izmantojam setter lai izveidotu ierocu sarakstu, un pec tam izsaukt to.
4. Mums ari ir setter Character.cs, es to apvienoju ar getter. Mes parliecinamies, ka jaunais ierocis noteikti ir panemts.


Papildu uzdevums. 3 ierocu tipi, starp ko speletajs var izveleties.
1. Es papildus izveidoju vel 2 skripti – IcyWeapon.cs un FireWeapon.cs
2. PoisonWeapon mums jau ir izveidots.
3. Ari pats ierocis tiek iestatits, izmantojot Setter (Character.cs).
4. Vispirms mes izveidojam ierocu sarakstu, no kura tos atlasisim.
5. [SerializeField] private List<Weapon> availableWeapons;
6. Mums ir jaatjaunina public void DoRound()- ChangePlayerWeapon();
7. Izveidojam jaunu metodi - private void ChangePlayerWeapon()
8. Musu manipulaciju rezultats speletajs katru gajienu izvelas jaunu ieroci.

Ari visi musu izveidotie papildu ieroci izmanto OOP (Mantošanu)
no Weapon.cs



