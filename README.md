<h1>Instructions:</h1>

*   There is a **build error** in the supplied code. Correct the bug and ensure the project builds.
*   There is a **runtime error** in the supplied code. Run the project, evaluate the stack error, and correct the bug.
*   The supplied CSV should populate a list of classes in the index page. We want you to display the classes on the index page, following these rules and using the supplied bootstrap CSS wherever possible:
    *   Each class should be displayed in a table like the one at the bottom
    *   There should be one table per distinct **quarter code**, where quarter code is the last 4 characters of **ClassID**. All classes with that quarter code should go in that table, and put an h2 above each labelling which quarter code it contains.
    *   Order these tables on the page by their quarter code, **descending**
    *   The classes inside each table should be ordered by **CourseID**, **ascending**
    *   **Item Number** should be the first four characters of **ClassID**
    *   **Credits** should display as a decimal in xx.x format. The values that are imported are from a legacy system; you will need to move the decimal point left 1 place on the whole numbers. For example, **50** should display as **5.0**.
    *   Convert the **Modality** supplied to a Modality display string by updating the get function for the **DisplayModality** property in the model, using this data:
        *   <table style="border-collapse: collapse; width: 32.3106%; height: 186px;" border="1">

            <tbody>

            <tr>

            <td style="width: 48.3179%;">Modality</td>

            <td style="width: 48.3179%;">DisplayModality</td>

            </tr>

            <tr>

            <td style="width: 48.3179%;">80</td>

            <td style="width: 48.3179%;">Hybrid</td>

            </tr>

            <tr>

            <td style="width: 48.3179%;">50</td>

            <td style="width: 48.3179%;">Virtual</td>

            </tr>

            <tr>

            <td style="width: 48.3179%;">51</td>

            <td style="width: 48.3179%;">Virtual Hybrid</td>

            </tr>

            <tr>

            <td style="width: 48.3179%;">3C</td>

            <td style="width: 48.3179%;">Online</td>

            </tr>

            <tr>

            <td style="width: 48.3179%;">[else]</td>

            <td style="width: 48.3179%;">Face to Face</td>

            </tr>

            </tbody>

            </table>

    *   The **Status** field should display the following:
        *   If **SectionStatusID1** is an 'X', show **Cancelled**, and make the whole row for that class **red**
        *   If the number of **StudentsEnrolled** is greater than or equal to the **ClassCapacity**, show **Closed**, and make the whole row for that class **yellow**
            *   Otherwise, show **Open - [number of seats remaining]**, and make the whole row for that class **green**

<table style="border-collapse: collapse; width: 100%;" border="1">

<tbody>

<tr>

<td style="width: 12.8011%;">Item Number</td>

<td style="width: 12.8011%;">Course ID</td>

<td style="width: 12.9025%;">Course Title</td>

<td style="width: 12.9025%;">Credits</td>

<td style="width: 12.9025%;">Days</td>

<td style="width: 12.9025%;">Modality</td>

<td style="width: 12.9025%;">Status</td>

</tr>

<tr>

<td style="width: 12.8011%;"> </td>

<td style="width: 12.8011%;"> </td>

<td style="width: 12.9025%;"> </td>

<td style="width: 12.9025%;"> </td>

<td style="width: 12.9025%;"> </td>

<td style="width: 12.9025%;"> </td>

<td style="width: 12.9025%;"> </td>

</tr>

</tbody>

</table>
