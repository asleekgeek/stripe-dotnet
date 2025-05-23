// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardSpendingControlsOptions : INestedOptions
    {
        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// of authorizations to allow. All other categories will be blocked. Cannot be set with
        /// <c>blocked_categories</c>.
        /// One of: <c>ac_refrigeration_repair</c>, <c>accounting_bookkeeping_services</c>,
        /// <c>advertising_services</c>, <c>agricultural_cooperative</c>,
        /// <c>airlines_air_carriers</c>, <c>airports_flying_fields</c>, <c>ambulance_services</c>,
        /// <c>amusement_parks_carnivals</c>, <c>antique_reproductions</c>, <c>antique_shops</c>,
        /// <c>aquariums</c>, <c>architectural_surveying_services</c>,
        /// <c>art_dealers_and_galleries</c>, <c>artists_supply_and_craft_shops</c>,
        /// <c>auto_and_home_supply_stores</c>, <c>auto_body_repair_shops</c>,
        /// <c>auto_paint_shops</c>, <c>auto_service_shops</c>, <c>automated_cash_disburse</c>,
        /// <c>automated_fuel_dispensers</c>, <c>automobile_associations</c>,
        /// <c>automotive_parts_and_accessories_stores</c>, <c>automotive_tire_stores</c>,
        /// <c>bail_and_bond_payments</c>, <c>bakeries</c>, <c>bands_orchestras</c>,
        /// <c>barber_and_beauty_shops</c>, <c>betting_casino_gambling</c>, <c>bicycle_shops</c>,
        /// <c>billiard_pool_establishments</c>, <c>boat_dealers</c>,
        /// <c>boat_rentals_and_leases</c>, <c>book_stores</c>,
        /// <c>books_periodicals_and_newspapers</c>, <c>bowling_alleys</c>, <c>bus_lines</c>,
        /// <c>business_secretarial_schools</c>, <c>buying_shopping_services</c>,
        /// <c>cable_satellite_and_other_pay_television_and_radio</c>,
        /// <c>camera_and_photographic_supply_stores</c>, <c>candy_nut_and_confectionery_stores</c>,
        /// <c>car_and_truck_dealers_new_used</c>, <c>car_and_truck_dealers_used_only</c>,
        /// <c>car_rental_agencies</c>, <c>car_washes</c>, <c>carpentry_services</c>,
        /// <c>carpet_upholstery_cleaning</c>, <c>caterers</c>,
        /// <c>charitable_and_social_service_organizations_fundraising</c>,
        /// <c>chemicals_and_allied_products</c>, <c>child_care_services</c>,
        /// <c>childrens_and_infants_wear_stores</c>, <c>chiropodists_podiatrists</c>,
        /// <c>chiropractors</c>, <c>cigar_stores_and_stands</c>,
        /// <c>civic_social_fraternal_associations</c>, <c>cleaning_and_maintenance</c>,
        /// <c>clothing_rental</c>, <c>colleges_universities</c>, <c>commercial_equipment</c>,
        /// <c>commercial_footwear</c>, <c>commercial_photography_art_and_graphics</c>,
        /// <c>commuter_transport_and_ferries</c>, <c>computer_network_services</c>,
        /// <c>computer_programming</c>, <c>computer_repair</c>, <c>computer_software_stores</c>,
        /// <c>computers_peripherals_and_software</c>, <c>concrete_work_services</c>,
        /// <c>construction_materials</c>, <c>consulting_public_relations</c>,
        /// <c>correspondence_schools</c>, <c>cosmetic_stores</c>, <c>counseling_services</c>,
        /// <c>country_clubs</c>, <c>courier_services</c>, <c>court_costs</c>,
        /// <c>credit_reporting_agencies</c>, <c>cruise_lines</c>, <c>dairy_products_stores</c>,
        /// <c>dance_hall_studios_schools</c>, <c>dating_escort_services</c>,
        /// <c>dentists_orthodontists</c>, <c>department_stores</c>, <c>detective_agencies</c>,
        /// <c>digital_goods_applications</c>, <c>digital_goods_games</c>,
        /// <c>digital_goods_large_volume</c>, <c>digital_goods_media</c>,
        /// <c>direct_marketing_catalog_merchant</c>,
        /// <c>direct_marketing_combination_catalog_and_retail_merchant</c>,
        /// <c>direct_marketing_inbound_telemarketing</c>,
        /// <c>direct_marketing_insurance_services</c>, <c>direct_marketing_other</c>,
        /// <c>direct_marketing_outbound_telemarketing</c>, <c>direct_marketing_subscription</c>,
        /// <c>direct_marketing_travel</c>, <c>discount_stores</c>, <c>doctors</c>,
        /// <c>door_to_door_sales</c>, <c>drapery_window_covering_and_upholstery_stores</c>,
        /// <c>drinking_places</c>, <c>drug_stores_and_pharmacies</c>,
        /// <c>drugs_drug_proprietaries_and_druggist_sundries</c>, <c>dry_cleaners</c>,
        /// <c>durable_goods</c>, <c>duty_free_stores</c>, <c>eating_places_restaurants</c>,
        /// <c>educational_services</c>, <c>electric_razor_stores</c>,
        /// <c>electric_vehicle_charging</c>, <c>electrical_parts_and_equipment</c>,
        /// <c>electrical_services</c>, <c>electronics_repair_shops</c>, <c>electronics_stores</c>,
        /// <c>elementary_secondary_schools</c>, <c>emergency_services_gcas_visa_use_only</c>,
        /// <c>employment_temp_agencies</c>, <c>equipment_rental</c>, <c>exterminating_services</c>,
        /// <c>family_clothing_stores</c>, <c>fast_food_restaurants</c>,
        /// <c>financial_institutions</c>, <c>fines_government_administrative_entities</c>,
        /// <c>fireplace_fireplace_screens_and_accessories_stores</c>, <c>floor_covering_stores</c>,
        /// <c>florists</c>, <c>florists_supplies_nursery_stock_and_flowers</c>,
        /// <c>freezer_and_locker_meat_provisioners</c>, <c>fuel_dealers_non_automotive</c>,
        /// <c>funeral_services_crematories</c>,
        /// <c>furniture_home_furnishings_and_equipment_stores_except_appliances</c>,
        /// <c>furniture_repair_refinishing</c>, <c>furriers_and_fur_shops</c>,
        /// <c>general_services</c>, <c>gift_card_novelty_and_souvenir_shops</c>,
        /// <c>glass_paint_and_wallpaper_stores</c>, <c>glassware_crystal_stores</c>,
        /// <c>golf_courses_public</c>, <c>government_licensed_horse_dog_racing_us_region_only</c>,
        /// <c>government_licensed_online_casions_online_gambling_us_region_only</c>,
        /// <c>government_owned_lotteries_non_us_region</c>,
        /// <c>government_owned_lotteries_us_region_only</c>, <c>government_services</c>,
        /// <c>grocery_stores_supermarkets</c>, <c>hardware_equipment_and_supplies</c>,
        /// <c>hardware_stores</c>, <c>health_and_beauty_spas</c>,
        /// <c>hearing_aids_sales_and_supplies</c>, <c>heating_plumbing_a_c</c>,
        /// <c>hobby_toy_and_game_shops</c>, <c>home_supply_warehouse_stores</c>, <c>hospitals</c>,
        /// <c>hotels_motels_and_resorts</c>, <c>household_appliance_stores</c>,
        /// <c>industrial_supplies</c>, <c>information_retrieval_services</c>,
        /// <c>insurance_default</c>, <c>insurance_underwriting_premiums</c>,
        /// <c>intra_company_purchases</c>,
        /// <c>jewelry_stores_watches_clocks_and_silverware_stores</c>, <c>landscaping_services</c>,
        /// <c>laundries</c>, <c>laundry_cleaning_services</c>, <c>legal_services_attorneys</c>,
        /// <c>luggage_and_leather_goods_stores</c>, <c>lumber_building_materials_stores</c>,
        /// <c>manual_cash_disburse</c>, <c>marinas_service_and_supplies</c>, <c>marketplaces</c>,
        /// <c>masonry_stonework_and_plaster</c>, <c>massage_parlors</c>,
        /// <c>medical_and_dental_labs</c>,
        /// <c>medical_dental_ophthalmic_and_hospital_equipment_and_supplies</c>,
        /// <c>medical_services</c>, <c>membership_organizations</c>,
        /// <c>mens_and_boys_clothing_and_accessories_stores</c>,
        /// <c>mens_womens_clothing_stores</c>, <c>metal_service_centers</c>, <c>miscellaneous</c>,
        /// <c>miscellaneous_apparel_and_accessory_shops</c>, <c>miscellaneous_auto_dealers</c>,
        /// <c>miscellaneous_business_services</c>, <c>miscellaneous_food_stores</c>,
        /// <c>miscellaneous_general_merchandise</c>, <c>miscellaneous_general_services</c>,
        /// <c>miscellaneous_home_furnishing_specialty_stores</c>,
        /// <c>miscellaneous_publishing_and_printing</c>, <c>miscellaneous_recreation_services</c>,
        /// <c>miscellaneous_repair_shops</c>, <c>miscellaneous_specialty_retail</c>,
        /// <c>mobile_home_dealers</c>, <c>motion_picture_theaters</c>,
        /// <c>motor_freight_carriers_and_trucking</c>, <c>motor_homes_dealers</c>,
        /// <c>motor_vehicle_supplies_and_new_parts</c>, <c>motorcycle_shops_and_dealers</c>,
        /// <c>motorcycle_shops_dealers</c>,
        /// <c>music_stores_musical_instruments_pianos_and_sheet_music</c>,
        /// <c>news_dealers_and_newsstands</c>, <c>non_fi_money_orders</c>,
        /// <c>non_fi_stored_value_card_purchase_load</c>, <c>nondurable_goods</c>,
        /// <c>nurseries_lawn_and_garden_supply_stores</c>, <c>nursing_personal_care</c>,
        /// <c>office_and_commercial_furniture</c>, <c>opticians_eyeglasses</c>,
        /// <c>optometrists_ophthalmologist</c>, <c>orthopedic_goods_prosthetic_devices</c>,
        /// <c>osteopaths</c>, <c>package_stores_beer_wine_and_liquor</c>,
        /// <c>paints_varnishes_and_supplies</c>, <c>parking_lots_garages</c>,
        /// <c>passenger_railways</c>, <c>pawn_shops</c>, <c>pet_shops_pet_food_and_supplies</c>,
        /// <c>petroleum_and_petroleum_products</c>, <c>photo_developing</c>,
        /// <c>photographic_photocopy_microfilm_equipment_and_supplies</c>,
        /// <c>photographic_studios</c>, <c>picture_video_production</c>,
        /// <c>piece_goods_notions_and_other_dry_goods</c>,
        /// <c>plumbing_heating_equipment_and_supplies</c>, <c>political_organizations</c>,
        /// <c>postal_services_government_only</c>,
        /// <c>precious_stones_and_metals_watches_and_jewelry</c>, <c>professional_services</c>,
        /// <c>public_warehousing_and_storage</c>, <c>quick_copy_repro_and_blueprint</c>,
        /// <c>railroads</c>, <c>real_estate_agents_and_managers_rentals</c>, <c>record_stores</c>,
        /// <c>recreational_vehicle_rentals</c>, <c>religious_goods_stores</c>,
        /// <c>religious_organizations</c>, <c>roofing_siding_sheet_metal</c>,
        /// <c>secretarial_support_services</c>, <c>security_brokers_dealers</c>,
        /// <c>service_stations</c>, <c>sewing_needlework_fabric_and_piece_goods_stores</c>,
        /// <c>shoe_repair_hat_cleaning</c>, <c>shoe_stores</c>, <c>small_appliance_repair</c>,
        /// <c>snowmobile_dealers</c>, <c>special_trade_services</c>, <c>specialty_cleaning</c>,
        /// <c>sporting_goods_stores</c>, <c>sporting_recreation_camps</c>,
        /// <c>sports_and_riding_apparel_stores</c>, <c>sports_clubs_fields</c>,
        /// <c>stamp_and_coin_stores</c>,
        /// <c>stationary_office_supplies_printing_and_writing_paper</c>,
        /// <c>stationery_stores_office_and_school_supply_stores</c>, <c>swimming_pools_sales</c>,
        /// <c>t_ui_travel_germany</c>, <c>tailors_alterations</c>,
        /// <c>tax_payments_government_agencies</c>, <c>tax_preparation_services</c>,
        /// <c>taxicabs_limousines</c>, <c>telecommunication_equipment_and_telephone_sales</c>,
        /// <c>telecommunication_services</c>, <c>telegraph_services</c>,
        /// <c>tent_and_awning_shops</c>, <c>testing_laboratories</c>,
        /// <c>theatrical_ticket_agencies</c>, <c>timeshares</c>, <c>tire_retreading_and_repair</c>,
        /// <c>tolls_bridge_fees</c>, <c>tourist_attractions_and_exhibits</c>,
        /// <c>towing_services</c>, <c>trailer_parks_campgrounds</c>,
        /// <c>transportation_services</c>, <c>travel_agencies_tour_operators</c>,
        /// <c>truck_stop_iteration</c>, <c>truck_utility_trailer_rentals</c>,
        /// <c>typesetting_plate_making_and_related_services</c>, <c>typewriter_stores</c>,
        /// <c>u_s_federal_government_agencies_or_departments</c>,
        /// <c>uniforms_commercial_clothing</c>, <c>used_merchandise_and_secondhand_stores</c>,
        /// <c>utilities</c>, <c>variety_stores</c>, <c>veterinary_services</c>,
        /// <c>video_amusement_game_supplies</c>, <c>video_game_arcades</c>,
        /// <c>video_tape_rental_stores</c>, <c>vocational_trade_schools</c>,
        /// <c>watch_jewelry_repair</c>, <c>welding_repair</c>, <c>wholesale_clubs</c>,
        /// <c>wig_and_toupee_stores</c>, <c>wires_money_orders</c>,
        /// <c>womens_accessory_and_specialty_shops</c>, <c>womens_ready_to_wear_stores</c>, or
        /// <c>wrecking_and_salvage_yards</c>.
        /// </summary>
        [JsonProperty("allowed_categories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_categories")]
#endif
        public List<string> AllowedCategories { get; set; }

        /// <summary>
        /// Array of strings containing representing countries from which authorizations will be
        /// allowed. Authorizations from merchants in all other countries will be declined. Country
        /// codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>). Cannot be set with
        /// <c>blocked_merchant_countries</c>. Provide an empty value to unset this control.
        /// </summary>
        [JsonProperty("allowed_merchant_countries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_merchant_countries")]
#endif
        public List<string> AllowedMerchantCountries { get; set; }

        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// of authorizations to decline. All other categories will be allowed. Cannot be set with
        /// <c>allowed_categories</c>.
        /// One of: <c>ac_refrigeration_repair</c>, <c>accounting_bookkeeping_services</c>,
        /// <c>advertising_services</c>, <c>agricultural_cooperative</c>,
        /// <c>airlines_air_carriers</c>, <c>airports_flying_fields</c>, <c>ambulance_services</c>,
        /// <c>amusement_parks_carnivals</c>, <c>antique_reproductions</c>, <c>antique_shops</c>,
        /// <c>aquariums</c>, <c>architectural_surveying_services</c>,
        /// <c>art_dealers_and_galleries</c>, <c>artists_supply_and_craft_shops</c>,
        /// <c>auto_and_home_supply_stores</c>, <c>auto_body_repair_shops</c>,
        /// <c>auto_paint_shops</c>, <c>auto_service_shops</c>, <c>automated_cash_disburse</c>,
        /// <c>automated_fuel_dispensers</c>, <c>automobile_associations</c>,
        /// <c>automotive_parts_and_accessories_stores</c>, <c>automotive_tire_stores</c>,
        /// <c>bail_and_bond_payments</c>, <c>bakeries</c>, <c>bands_orchestras</c>,
        /// <c>barber_and_beauty_shops</c>, <c>betting_casino_gambling</c>, <c>bicycle_shops</c>,
        /// <c>billiard_pool_establishments</c>, <c>boat_dealers</c>,
        /// <c>boat_rentals_and_leases</c>, <c>book_stores</c>,
        /// <c>books_periodicals_and_newspapers</c>, <c>bowling_alleys</c>, <c>bus_lines</c>,
        /// <c>business_secretarial_schools</c>, <c>buying_shopping_services</c>,
        /// <c>cable_satellite_and_other_pay_television_and_radio</c>,
        /// <c>camera_and_photographic_supply_stores</c>, <c>candy_nut_and_confectionery_stores</c>,
        /// <c>car_and_truck_dealers_new_used</c>, <c>car_and_truck_dealers_used_only</c>,
        /// <c>car_rental_agencies</c>, <c>car_washes</c>, <c>carpentry_services</c>,
        /// <c>carpet_upholstery_cleaning</c>, <c>caterers</c>,
        /// <c>charitable_and_social_service_organizations_fundraising</c>,
        /// <c>chemicals_and_allied_products</c>, <c>child_care_services</c>,
        /// <c>childrens_and_infants_wear_stores</c>, <c>chiropodists_podiatrists</c>,
        /// <c>chiropractors</c>, <c>cigar_stores_and_stands</c>,
        /// <c>civic_social_fraternal_associations</c>, <c>cleaning_and_maintenance</c>,
        /// <c>clothing_rental</c>, <c>colleges_universities</c>, <c>commercial_equipment</c>,
        /// <c>commercial_footwear</c>, <c>commercial_photography_art_and_graphics</c>,
        /// <c>commuter_transport_and_ferries</c>, <c>computer_network_services</c>,
        /// <c>computer_programming</c>, <c>computer_repair</c>, <c>computer_software_stores</c>,
        /// <c>computers_peripherals_and_software</c>, <c>concrete_work_services</c>,
        /// <c>construction_materials</c>, <c>consulting_public_relations</c>,
        /// <c>correspondence_schools</c>, <c>cosmetic_stores</c>, <c>counseling_services</c>,
        /// <c>country_clubs</c>, <c>courier_services</c>, <c>court_costs</c>,
        /// <c>credit_reporting_agencies</c>, <c>cruise_lines</c>, <c>dairy_products_stores</c>,
        /// <c>dance_hall_studios_schools</c>, <c>dating_escort_services</c>,
        /// <c>dentists_orthodontists</c>, <c>department_stores</c>, <c>detective_agencies</c>,
        /// <c>digital_goods_applications</c>, <c>digital_goods_games</c>,
        /// <c>digital_goods_large_volume</c>, <c>digital_goods_media</c>,
        /// <c>direct_marketing_catalog_merchant</c>,
        /// <c>direct_marketing_combination_catalog_and_retail_merchant</c>,
        /// <c>direct_marketing_inbound_telemarketing</c>,
        /// <c>direct_marketing_insurance_services</c>, <c>direct_marketing_other</c>,
        /// <c>direct_marketing_outbound_telemarketing</c>, <c>direct_marketing_subscription</c>,
        /// <c>direct_marketing_travel</c>, <c>discount_stores</c>, <c>doctors</c>,
        /// <c>door_to_door_sales</c>, <c>drapery_window_covering_and_upholstery_stores</c>,
        /// <c>drinking_places</c>, <c>drug_stores_and_pharmacies</c>,
        /// <c>drugs_drug_proprietaries_and_druggist_sundries</c>, <c>dry_cleaners</c>,
        /// <c>durable_goods</c>, <c>duty_free_stores</c>, <c>eating_places_restaurants</c>,
        /// <c>educational_services</c>, <c>electric_razor_stores</c>,
        /// <c>electric_vehicle_charging</c>, <c>electrical_parts_and_equipment</c>,
        /// <c>electrical_services</c>, <c>electronics_repair_shops</c>, <c>electronics_stores</c>,
        /// <c>elementary_secondary_schools</c>, <c>emergency_services_gcas_visa_use_only</c>,
        /// <c>employment_temp_agencies</c>, <c>equipment_rental</c>, <c>exterminating_services</c>,
        /// <c>family_clothing_stores</c>, <c>fast_food_restaurants</c>,
        /// <c>financial_institutions</c>, <c>fines_government_administrative_entities</c>,
        /// <c>fireplace_fireplace_screens_and_accessories_stores</c>, <c>floor_covering_stores</c>,
        /// <c>florists</c>, <c>florists_supplies_nursery_stock_and_flowers</c>,
        /// <c>freezer_and_locker_meat_provisioners</c>, <c>fuel_dealers_non_automotive</c>,
        /// <c>funeral_services_crematories</c>,
        /// <c>furniture_home_furnishings_and_equipment_stores_except_appliances</c>,
        /// <c>furniture_repair_refinishing</c>, <c>furriers_and_fur_shops</c>,
        /// <c>general_services</c>, <c>gift_card_novelty_and_souvenir_shops</c>,
        /// <c>glass_paint_and_wallpaper_stores</c>, <c>glassware_crystal_stores</c>,
        /// <c>golf_courses_public</c>, <c>government_licensed_horse_dog_racing_us_region_only</c>,
        /// <c>government_licensed_online_casions_online_gambling_us_region_only</c>,
        /// <c>government_owned_lotteries_non_us_region</c>,
        /// <c>government_owned_lotteries_us_region_only</c>, <c>government_services</c>,
        /// <c>grocery_stores_supermarkets</c>, <c>hardware_equipment_and_supplies</c>,
        /// <c>hardware_stores</c>, <c>health_and_beauty_spas</c>,
        /// <c>hearing_aids_sales_and_supplies</c>, <c>heating_plumbing_a_c</c>,
        /// <c>hobby_toy_and_game_shops</c>, <c>home_supply_warehouse_stores</c>, <c>hospitals</c>,
        /// <c>hotels_motels_and_resorts</c>, <c>household_appliance_stores</c>,
        /// <c>industrial_supplies</c>, <c>information_retrieval_services</c>,
        /// <c>insurance_default</c>, <c>insurance_underwriting_premiums</c>,
        /// <c>intra_company_purchases</c>,
        /// <c>jewelry_stores_watches_clocks_and_silverware_stores</c>, <c>landscaping_services</c>,
        /// <c>laundries</c>, <c>laundry_cleaning_services</c>, <c>legal_services_attorneys</c>,
        /// <c>luggage_and_leather_goods_stores</c>, <c>lumber_building_materials_stores</c>,
        /// <c>manual_cash_disburse</c>, <c>marinas_service_and_supplies</c>, <c>marketplaces</c>,
        /// <c>masonry_stonework_and_plaster</c>, <c>massage_parlors</c>,
        /// <c>medical_and_dental_labs</c>,
        /// <c>medical_dental_ophthalmic_and_hospital_equipment_and_supplies</c>,
        /// <c>medical_services</c>, <c>membership_organizations</c>,
        /// <c>mens_and_boys_clothing_and_accessories_stores</c>,
        /// <c>mens_womens_clothing_stores</c>, <c>metal_service_centers</c>, <c>miscellaneous</c>,
        /// <c>miscellaneous_apparel_and_accessory_shops</c>, <c>miscellaneous_auto_dealers</c>,
        /// <c>miscellaneous_business_services</c>, <c>miscellaneous_food_stores</c>,
        /// <c>miscellaneous_general_merchandise</c>, <c>miscellaneous_general_services</c>,
        /// <c>miscellaneous_home_furnishing_specialty_stores</c>,
        /// <c>miscellaneous_publishing_and_printing</c>, <c>miscellaneous_recreation_services</c>,
        /// <c>miscellaneous_repair_shops</c>, <c>miscellaneous_specialty_retail</c>,
        /// <c>mobile_home_dealers</c>, <c>motion_picture_theaters</c>,
        /// <c>motor_freight_carriers_and_trucking</c>, <c>motor_homes_dealers</c>,
        /// <c>motor_vehicle_supplies_and_new_parts</c>, <c>motorcycle_shops_and_dealers</c>,
        /// <c>motorcycle_shops_dealers</c>,
        /// <c>music_stores_musical_instruments_pianos_and_sheet_music</c>,
        /// <c>news_dealers_and_newsstands</c>, <c>non_fi_money_orders</c>,
        /// <c>non_fi_stored_value_card_purchase_load</c>, <c>nondurable_goods</c>,
        /// <c>nurseries_lawn_and_garden_supply_stores</c>, <c>nursing_personal_care</c>,
        /// <c>office_and_commercial_furniture</c>, <c>opticians_eyeglasses</c>,
        /// <c>optometrists_ophthalmologist</c>, <c>orthopedic_goods_prosthetic_devices</c>,
        /// <c>osteopaths</c>, <c>package_stores_beer_wine_and_liquor</c>,
        /// <c>paints_varnishes_and_supplies</c>, <c>parking_lots_garages</c>,
        /// <c>passenger_railways</c>, <c>pawn_shops</c>, <c>pet_shops_pet_food_and_supplies</c>,
        /// <c>petroleum_and_petroleum_products</c>, <c>photo_developing</c>,
        /// <c>photographic_photocopy_microfilm_equipment_and_supplies</c>,
        /// <c>photographic_studios</c>, <c>picture_video_production</c>,
        /// <c>piece_goods_notions_and_other_dry_goods</c>,
        /// <c>plumbing_heating_equipment_and_supplies</c>, <c>political_organizations</c>,
        /// <c>postal_services_government_only</c>,
        /// <c>precious_stones_and_metals_watches_and_jewelry</c>, <c>professional_services</c>,
        /// <c>public_warehousing_and_storage</c>, <c>quick_copy_repro_and_blueprint</c>,
        /// <c>railroads</c>, <c>real_estate_agents_and_managers_rentals</c>, <c>record_stores</c>,
        /// <c>recreational_vehicle_rentals</c>, <c>religious_goods_stores</c>,
        /// <c>religious_organizations</c>, <c>roofing_siding_sheet_metal</c>,
        /// <c>secretarial_support_services</c>, <c>security_brokers_dealers</c>,
        /// <c>service_stations</c>, <c>sewing_needlework_fabric_and_piece_goods_stores</c>,
        /// <c>shoe_repair_hat_cleaning</c>, <c>shoe_stores</c>, <c>small_appliance_repair</c>,
        /// <c>snowmobile_dealers</c>, <c>special_trade_services</c>, <c>specialty_cleaning</c>,
        /// <c>sporting_goods_stores</c>, <c>sporting_recreation_camps</c>,
        /// <c>sports_and_riding_apparel_stores</c>, <c>sports_clubs_fields</c>,
        /// <c>stamp_and_coin_stores</c>,
        /// <c>stationary_office_supplies_printing_and_writing_paper</c>,
        /// <c>stationery_stores_office_and_school_supply_stores</c>, <c>swimming_pools_sales</c>,
        /// <c>t_ui_travel_germany</c>, <c>tailors_alterations</c>,
        /// <c>tax_payments_government_agencies</c>, <c>tax_preparation_services</c>,
        /// <c>taxicabs_limousines</c>, <c>telecommunication_equipment_and_telephone_sales</c>,
        /// <c>telecommunication_services</c>, <c>telegraph_services</c>,
        /// <c>tent_and_awning_shops</c>, <c>testing_laboratories</c>,
        /// <c>theatrical_ticket_agencies</c>, <c>timeshares</c>, <c>tire_retreading_and_repair</c>,
        /// <c>tolls_bridge_fees</c>, <c>tourist_attractions_and_exhibits</c>,
        /// <c>towing_services</c>, <c>trailer_parks_campgrounds</c>,
        /// <c>transportation_services</c>, <c>travel_agencies_tour_operators</c>,
        /// <c>truck_stop_iteration</c>, <c>truck_utility_trailer_rentals</c>,
        /// <c>typesetting_plate_making_and_related_services</c>, <c>typewriter_stores</c>,
        /// <c>u_s_federal_government_agencies_or_departments</c>,
        /// <c>uniforms_commercial_clothing</c>, <c>used_merchandise_and_secondhand_stores</c>,
        /// <c>utilities</c>, <c>variety_stores</c>, <c>veterinary_services</c>,
        /// <c>video_amusement_game_supplies</c>, <c>video_game_arcades</c>,
        /// <c>video_tape_rental_stores</c>, <c>vocational_trade_schools</c>,
        /// <c>watch_jewelry_repair</c>, <c>welding_repair</c>, <c>wholesale_clubs</c>,
        /// <c>wig_and_toupee_stores</c>, <c>wires_money_orders</c>,
        /// <c>womens_accessory_and_specialty_shops</c>, <c>womens_ready_to_wear_stores</c>, or
        /// <c>wrecking_and_salvage_yards</c>.
        /// </summary>
        [JsonProperty("blocked_categories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blocked_categories")]
#endif
        public List<string> BlockedCategories { get; set; }

        /// <summary>
        /// Array of strings containing representing countries from which authorizations will be
        /// declined. Country codes should be ISO 3166 alpha-2 country codes (e.g. <c>US</c>).
        /// Cannot be set with <c>allowed_merchant_countries</c>. Provide an empty value to unset
        /// this control.
        /// </summary>
        [JsonProperty("blocked_merchant_countries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blocked_merchant_countries")]
#endif
        public List<string> BlockedMerchantCountries { get; set; }

        /// <summary>
        /// Limit spending with amount-based rules that apply across any cards this card replaced
        /// (i.e., its <c>replacement_for</c> card and <em>that</em> card's <c>replacement_for</c>
        /// card, up the chain).
        /// </summary>
        [JsonProperty("spending_limits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spending_limits")]
#endif
        public List<CardSpendingControlsSpendingLimitOptions> SpendingLimits { get; set; }
    }
}
